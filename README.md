# SpaceFed

An open-source resource-management game, combining the likes of games like Prison Architect and Endless Space to reach the final goal of conquering the universe.

## Contents
- 1 - [Introduction](#1-introduction)
- 2 - [Building](#2-building)
	- 2.1 - [Building Prerequisites](#21-building-prerequisites)
	- 2.2 - [Compiling and Running](#22-compiling-and-running)
- 3 - [Contributing](#3-contributing)
  - 3.1 - [New Features](#31-new-features)
  - 3.2 - [Bugfixes](#42-bugfixes)
## 1 Introduction
The goal of this project is to create an open source game, combining great gaming elements, like the construction-management aspects of e.g. Prison Architect and the exploration aspects of a game like Endless Space. 
The ultimate goal is to have a game that lets you build your own settlements on space-rocks (your homeplanet at first, and conquered planets, moons and possibly stars later on).

## 2 Building

### 2.1 Building Prerequisites
SpaceFed development makes use of the following techniques:

* Visual Studio 2015 (Enterprise / Professional / [Community (Free)](https://www.visualstudio.com/products/visual-studio-community-vs))
* MonoGame for Windows (DirectX)
* Windows Vista / 7 / 8 / 10
* Latest DirectX

### 2.2 Compiling and running

1. Check out the repository by using a git-compatible tool, e.g. [Github Desktop](https://desktop.github.com), [TortoiseGit](https://tortoisegit.org/download/) and [more](https://help.github.com/articles/which-remote-url-should-i-use)
2. Select the branch you wish to compile (this can be a stable release or a development branch)
3. Open the solution using Visual Studio 2015 and press 'Build'. Doing this for the first time will take a bit longer as Nuget will restore missing packages
4. Start the program by clicking 'Start', or by starting the executable from the build directory

## 3 Contributing
SpaceFed uses the Gitflow workflow. It consists of a `master` branch in which the latest stable version of the game can be found. This master branch should be branched from and pull requested to when performing hotfixes only. 
All other work should be done by branching off and pull requesting into the `development` branch.  For readibility, please name the branch with the following pattern: `[master/development]/[issue-number]`

### 3.1 New Features
Feel free to work on any feature and submit a pull request to the develop branch with the implementation. Be sure to create an issue ticket and refer to the issue's number in the branch title.

### 3.2 Bugfixes
Feel free to work on any bug and submit a pull request to the develop branch with the fix. Be sure to create an issue ticket and refer to the issue's number in the branch title.

### 3.3 Coding Standards
Please check out our [coding standards](#http://github.com/SpaceFed/STANDARDS.md) and make sure to follow them before issuing a pull request.

