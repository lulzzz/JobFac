
# JobFac: The Background Job Factory

The contents of this repository are a work-in-progress.

Watch this space for real documentation links.

Status 2019-dec-23: dev-quality host and client can launch jobs and track status to completion.

## Summary

JobFac runs and manages console programs acting as background or automated processing jobs. 

Jobs launch on a scheduled basis or on-demand via service calls. Single-server or even local implementation is possible, but the primary use-case is job-execution load balanced across a self-managing server cluster. The system includes the usual monitoring, notification, and reporting features found in systems like this.

Job interaction is available to client applications through an HTTP-based API. While a .NET client application could take advantage of binary-level connectivity to the job services, a system of this nature does not typically require such convenience/performance tradeoffs.

There is also a sequencing system which can launch and control a series of jobs with conditional start rules at each step and branching features based on job outcome (success, failure, mixed). Sequences can also be scheduled or started on-demand and can provide altered arguments or JobFac payloads to any of the jobs in the sequence.

Currently this is implemented as one giant solution. Later it will be split into several solutions and a few NuGet packages. Each project in this repository has a separate README with a bit more detail about the project (specifically any project with a JobFac prefix, the rest are early-stage, temporary test projects such as DevConsoleHost).

The goal is to keep this fully open sourced and free to use, along the same lines of other popular .NET projects like Serilog or IdentityServer4.

## Dependencies

* .NET Core 3.1
* Microsoft Orleans 3.0
* Dapper 2.0
* SQL Server 2016+

