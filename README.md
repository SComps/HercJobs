# HercJobs

<b>NOTE: This is a winforms application targeted at .NET 8.0.  This version of dotnet
does not support WinForms applications on linux.  While it's possible to create
winforms applications on linux using Mono, those applications must be targetted at
an older version (4.5) of the .NET Framework -- not .NET CORE and above.  As such
there is no plans to support porting this application to linux or MacOS.</b>


A windows GUI application to submit jobs to a Hercules guest via TCP/IP to a hercules
3505 card reader set up as sockdev.

This is a work in progress.  Future additions will hopefully be to intercept the printer
output, not only for this job, but all jobs such as Virtual1403 does.  Note, Virtual1403 
is definitely the best printer application for Hercules (and I personally use it).  This
application will pale in comparison for that job.  I'm intending to include this functionality
as a personal challenge.
