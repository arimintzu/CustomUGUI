# Custom UGUI

# BetterContentFitter
Whenever using default content size fitter unity UI, sometimes it's not updated (usually happened on LayoutGroup).
This will always update whenever the child updated.
I used MEC Timing for the coroutine, you can change it to default unity coroutine.

# DoTweenToggle
Steps to Implement a Custom Toggle with DoTween
1. Set Up the UI in Unity
Canvas: Right-click > UI > Canvas.
Toggle:
Right-click Canvas > UI > Toggle.
Remove the default Checkmark and Label.
Background (Oval Shape):
Replace the Background with a custom oval sprite.
Assign it a RectTransform with the desired size.
Knob (Circle):
Add a child Image under the Background.
Set its shape to a circle (using a custom sprite or Unity's built-in circle).
