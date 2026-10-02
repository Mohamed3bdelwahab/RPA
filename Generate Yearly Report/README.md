# Generate Yearly Report

UiPath Windows automation project for retrieving report-related work items, downloading monthly reports, producing a yearly report, and uploading results.

## Visible workflow flow

1. Initialize the automation framework and applications.
2. Log in to the ACME-style environment.
3. Retrieve and navigate work items.
4. Extract the information required for report processing.
5. Navigate to monthly reports and download report files.
6. Build/process the yearly report.
7. Navigate to the upload area and upload the resulting report.
8. Update the work item and close/clean up through framework workflows.

## Project metadata

- Entry point: `Main.xaml`
- UiPath Studio: 23.4.2
- Target framework: Windows
- Project version: 1.0.0
- Logging exclusions include private fields and password-pattern data.

## Tests

The `Tests/` folder includes workflow test cases for initialization, transaction handling, processing, and the main workflow.

> This README describes the public workflow structure. Credentials, production data, and environment-specific configuration are intentionally omitted.
