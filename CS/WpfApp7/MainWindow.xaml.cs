using DevExpress.Diagram.Core;
using DevExpress.Diagram.Core.Native;
using DevExpress.Mvvm.Native;
using DevExpress.Xpf.Diagram;
using System.Linq;
using System.Windows;

namespace WpfApp7 {
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
        }

        private void DiagramDesignerControl_AddingNewItem(object sender, DiagramAddingNewItemEventArgs e) {
            e.Cancel = (e.Item is DiagramShape shape && shape.Shape == BasicShapes.Rectangle);
            e.Handled = true;
        }

        private void DiagramDesignerControl_BeforeItemsMoving(object sender, DiagramBeforeItemsMovingEventArgs e) {
            if (e.Items.Where(item => item is DiagramShape shape && shape.ParentItem != null && shape.Shape == BasicShapes.Triangle).Count() > 0)
                e.Items.Clear();
            e.Handled = true;
        }

        private void DiagramDesignerControl_ItemsMoving(object sender, DiagramItemsMovingEventArgs e) {
            //condition 1: the item type
            if (e.Items.Where(item => item.Item is DiagramShape shape && shape.Shape == BasicShapes.Ellipse).Count() > 0)
                e.Cancel = true;

            //condition 2: the item parent
            else if (e.Items.Where(item => CheckItemParent(item)).Count() > 0)
                e.Allow = false;

            //condition 3: the item position
            else if (e.Items.Where(item => CheckItemPosition(item)).Count() > 0)
                e.Allow = false;

            e.Handled = true;
        }

        public bool CheckItemParent(MovingItem item) {
            if (item.Item is DiagramShape shape && shape.Shape == BasicShapes.RightTriangle) {
                var parent = item.NewParent as DiagramContainer;
                if (parent != null && parent.Items.Count > 0 && parent.Items.OfType<DiagramShape>().Where(child => child.Shape == shape.Shape).Count() > 0)
                    return true;
            }
            return false;
        }

        public bool CheckItemPosition(MovingItem item)  {
            if (item.Item is DiagramShape shape && shape.Shape == BasicShapes.Pentagon) {
                var itemRect = new Rect(item.NewDiagramPosition, new System.Windows.Size(item.Item.ActualWidth, item.Item.ActualHeight));
                foreach (var diagramShape in diagramControl1.Items.OfType<DiagramShape>().Where(x => x != shape)) {
                    var diagramShapeRect = diagramShape.RotatedDiagramBounds().Rect;
                    var extendedBounds = new Rect(diagramShapeRect.X - 100, diagramShapeRect.Y - 100, diagramShapeRect.Width + 200, diagramShapeRect.Height + 200);

                    if (extendedBounds.Contains(itemRect))
                        return true;
                }
            }
            return false;
        }
    }
}
