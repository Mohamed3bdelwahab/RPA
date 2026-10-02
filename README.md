# RPA & Automation Portfolio

A public collection of robotic process automation examples, workflow diagrams, Python utilities, and Excel/VBA automation work.

## What is in this repository

### UiPath automation projects

#### Calculate Client Security Hash Assignment
A UiPath Windows project structured around transaction processing and reusable workflow components. The repository includes:

- ACME login and credential workflows
- work-item navigation and data extraction
- SHA-1 hash-generation steps
- work-item status updates
- framework workflows for initialization, transaction processing, retry handling, screenshots, application cleanup, and status management
- workflow test cases

The project metadata identifies `Main.xaml` as the entry point, targets Windows, and was created with UiPath Studio 23.4.2. Runtime options exclude private fields and password-pattern data from logging.

#### Generate Yearly Report
A second UiPath Windows automation focused on report processing. Visible workflow groups cover:

- ACME login and work-item navigation
- data extraction
- monthly-report navigation and download
- yearly-report generation
- report upload and work-item update
- reusable framework lifecycle workflows
- workflow test cases

This project also targets Windows and uses `Main.xaml` as its entry point.

### Process diagrams
The `Diagram/` folder contains PDF workflow/process diagrams covering examples such as mail creation, training classes, NTRA, gym deactivation, and other process-mapping exercises.

### Python / OpenCV utilities
The `Python/` folder contains small image-processing experiments and utilities, including OpenCV-based image loading/cropping examples.

### Excel / VBA automation
The `VBA Macro Excel/` folder contains VBA/VB helpers for spreadsheet-oriented automation tasks such as:

- refreshing workbook data
- copying/filtering data
- formatting null values
- dispatch/agent-oriented copy operations
- email-row cleanup

## Repository structure

```text
RPA/
├── Calculate Client Security Hash Assignment/
├── Generate Yearly Report/
├── Diagram/
├── Python/
└── VBA Macro Excel/
```

## Technologies represented

- UiPath Studio / Windows workflows
- XAML automation workflows
- Visual Basic / VBA
- Python
- OpenCV
- Excel automation
- process mapping and workflow design

## Notes

These projects are portfolio and learning examples. Environment-specific credentials, customer data, production secrets, and private operational configuration are intentionally not documented here.
