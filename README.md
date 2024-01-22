<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1208164)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Diagram Control - Track and Restrict Drag Actions

This example demonstrates how to restrict different drag actions in the [Diagram Control](https://docs.devexpress.com/WPF/115046/controls-and-libraries/diagram-control).

The `DiagramControl` allows you to use multiple events (raised at different moments) to customize or prohibit drag actions:

* The [AddingNewItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.AddingNewItem) event is raised when a user drags a new item to the canvas.
* The [BeforeItemsMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.BeforeItemsMoving) event is raised when a user initiates the item drag/move action. This event allows you to customize dragged items.
* The [ItemsMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.ItemsMoving) event is raised during the item drag/move action. This event allows you to restrict this action based on stage, item position, and item parent.

This example demonstrates how to handle these events to implement the following restrictions:

* You cannot drop "Rectangle" and "Ellipse" shapes to the canvas.
* You cannot move the "Triangle" shape after you drop it to the canvas.
* You cannot move the "RightTriangle" shape to a container if it contains at least one "RightTriangle" shape.
* You cannot drop the "Pentagon" shape near other shapes.

## Files to Review

- [MainWindow.xaml](./CS/WpfApp7/MainWindow.xaml)
- [MainWindow.xaml.cs](./CS/WpfApp7/MainWindow.xaml.cs)

## Documentation

- [DiagramControl.AddingNewItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.AddingNewItem)
- [DiagramControl.BeforeItemsMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.BeforeItemsMoving)
- [DiagramControl.ItemsMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.ItemsMoving)
