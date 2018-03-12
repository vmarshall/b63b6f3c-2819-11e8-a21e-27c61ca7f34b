# Unity problem solving test

## Overview of functionality

Project contains a very simple 2 view application created in Unity 2017.2.1.
Base functionality is very simple. User pressed the “List view” button. user should be the seamlessly taken to another view within the app displaying the dynamic list of elements (called cells). Each cell is containing some static UI elements and a dynamic text label that is populated.

## Source

Test project can be pulled from the repository under this link: `https://bitbucket.org/lukos86/unity-problem-solving-test`

## Existing problems

1. Project is very heavy on the rendering side and logic side
2. There is a very significant delay between pressing the “List view” button and animated transition to the next view. Possibly caused by main thread task to generate and populate tons of data.
3. UI isn't looking correctly on different aspect ratios. Looks correctly in 16:10. For example 3:4 aspect ratio UI isn't looking right. List should fill the full width of the screen
4. In second view, scrolling list isn't working correctly. Does not allow to scroll all the way down to the bottom.
5. Project displays a number in the list of cells, for some reason assigning text gives negative value, even tho number is incremented with positive values. Also some of the cells text aren't rendering the whole number values.

## Requirements

Fix the problems without modifying data feeding the list of cells.
Make sure app does run as smooth as possible and APK build file is as small as possible.

## Deliverable

Fork of the repository containing fixes. AND Android APK file.
