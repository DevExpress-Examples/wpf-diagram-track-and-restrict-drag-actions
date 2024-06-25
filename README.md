<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/735920457/17.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1208164)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WPF Diagram Control - Track and Restrict Drag Actions

This example restricts different drag actions within the DevExpress [WPF Diagram Control](https://docs.devexpress.com/WPF/115046/controls-and-libraries/diagram-control).

The `DiagramControl` allows you to use multiple events (raised at different moments in time) to customize/prohibit drag operations:

* The [AddingNewItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.AddingNewItem) event is raised when a user drags a new item to the canvas.
* The [BeforeItemsMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.BeforeItemsMoving) event is raised when a user initiates an item drag/move action. This event allows you to customize dragged items.
* The [ItemsMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.ItemsMoving) event is raised during item drag/move operations. This event allows you to restrict this action based on stage, item position, and item parent.

By handling these events, you can introduce the following restrictions:

* You cannot drop "Rectangle" and "Ellipse" shapes to the canvas.
* You cannot move the "Triangle" shape once you drop it onto the canvas.
* You cannot move the "RightTriangle" shape to a container if it contains at least one "RightTriangle" shape.
* You cannot drop the "Pentagon" shape near other shapes.

## Files to Review

- [MainWindow.xaml](./CS/WpfApp7/MainWindow.xaml)
- [MainWindow.xaml.cs](./CS/WpfApp7/MainWindow.xaml.cs)

## Documentation

- [DiagramControl.AddingNewItem](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.AddingNewItem)
- [DiagramControl.BeforeItemsMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.BeforeItemsMoving)
- [DiagramControl.ItemsMoving](https://docs.devexpress.com/WPF/DevExpress.Xpf.Diagram.DiagramControl.ItemsMoving)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagram-track-and-restrict-drag-actions&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-diagram-track-and-restrict-drag-actions&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
