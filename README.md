# Double Buffering in WinForms
This is a demo program showing the differences of buffered and unbuffered drawing.

## What is wrong with drawing normally?
Between each frame the whole display is filled white and then the objects are drawn into it.
The user perceives the clearing of the screen and the slightly offset drawing as flickering.
This effect gets even worse if the objects are moving or if it takes a small time to compute their position

## How does double buffering help?
Instead of drawing everything as soon as it is computed double buffering creates a buffer the objects are drawn into.
Then the whole buffer is drawn onto the screen at the same time. This gets rid of the distracting flickering.

## Example
Normal Graphics are used on the left side while the right side uses [my double buffering class](https://gist.github.com/JKamue/97476d20b1a3a965079a30a3de33c4fe).
<p align="center">
  <img width="640" height="342" src="Docs/example.gif">
</p>
