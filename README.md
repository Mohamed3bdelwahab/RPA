# RPA Automation Portfolio

A collection of practical automation examples built with **UiPath**, **Python/OpenCV**, and **Excel/VBA**.

This repository is organized as a technical portfolio of workflow automation patterns, supporting scripts, diagrams, and UiPath projects.

## What this repository demonstrates

- UiPath Windows automation projects with structured workflow folders
- UI automation, Excel automation, system activities, and UiPath testing activities
- Visual Basic expressions inside UiPath workflows
- Supporting Python/OpenCV image-processing utilities
- Excel/VBA automation examples
- Process and workflow diagrams

## Featured UiPath projects

### Calculate Client Security Hash Assignment

A UiPath Windows process with a `Main.xaml` entry point and project structure that includes ACME, Data, Documentation, Framework, exception screenshots, and test assets.

**UiPath project details**

- UiPath Studio: `23.4.2.0`
- Target framework: `Windows`
- Expression language: `VisualBasic`
- UiPath Excel Activities: `2.20.2`
- UiPath System Activities: `23.4.3`
- UiPath Testing Activities: `23.4.1`
- UiPath UI Automation Activities: `23.4.6`

[View project](./Calculate%20Client%20Security%20Hash%20Assignment)

### Generate Yearly Report

A UiPath Windows process with a `Main.xaml` entry point and dedicated folders for report downloading, framework logic, data, documentation, exception screenshots, and tests.

**UiPath project details**

- UiPath Studio: `23.4.2.0`
- Target framework: `Windows`
- Expression language: `VisualBasic`
- UiPath Excel Activities: `2.20.2`
- UiPath System Activities: `23.4.3`
- UiPath Testing Activities: `23.4.1`
- UiPath UI Automation Activities: `23.4.6`

[View project](./Generate%20Yearly%20Report)

## Supporting automation utilities

### Python / OpenCV

The [`Python`](./Python) folder contains small image-processing utilities, including OpenCV-based image cropping and image manipulation scripts.

Current examples include:

- `CropByCV2.py`
- `image crop.py`
- `openCVImage.py`

### Excel / VBA

The [`VBA Macro Excel`](./VBA%20Macro%20Excel) folder contains Excel/VBA automation material that complements the RPA workflows.

### Workflow diagrams

The [`Diagram`](./Diagram) folder contains process-design and workflow-diagram material.

## Technology stack

| Area | Technologies |
| --- | --- |
| RPA | UiPath Studio, UiPath UI Automation, UiPath Excel, UiPath System Activities |
| Workflow language | Visual Basic / XAML |
| Testing | UiPath Testing Activities |
| Scripting | Python |
| Image processing | OpenCV |
| Office automation | Excel, VBA |

## Repository structure

```text
RPA/
├── Calculate Client Security Hash Assignment/
├── Generate Yearly Report/
├── Python/
├── VBA Macro Excel/
└── Diagram/
```

## Getting started

### UiPath projects

1. Clone this repository.
2. Open the desired project folder in UiPath Studio.
3. Allow UiPath Studio to restore the dependencies defined in `project.json`.
4. Review local configuration and input data before execution.
5. Run the project's `Main.xaml` entry point.

### Python utilities

Open the scripts in the `Python` folder and install any Python/OpenCV dependencies required by the individual script before running it.

## About

This repository highlights hands-on workflow automation across UiPath, Python, image processing, and Office automation.
