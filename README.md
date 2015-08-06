Amazon SES Tester
==============
This is a simple Windows Forms application that will let you test connectivity and access to your Amazon SES account from the server/workstation you run this application from.

Purpose
------------
The purpose of this application is to verify that you have:

1. The correct Amazon SES credentials/settings
2. Connectivity to Amazon SES from your current network location (i.e. No firewall rules in the way)
3. The domain you try to send mail from is verified by Amazon

Requirements
------------
1. Windows (deal with it)
  1. .Net Framework 4.5
2. Visual Studio 2013 (or the compiled download from https://github.com/ahrenstein/AmazonSESTester/releases)

Installation Tips
------------
There is no installer since this is a single executable file.

Limitations
------------
1. Windows is required, so if you want to test Amazon SES from a linux or other non-Windows server, you will need to use something else.

Known Issues
------------
1. None so far :)

Bug Fixes & Changes
------------

1. v1.0.17098 build 5696
  1. Fixed a typo in the us-east-1 domain.
2. v1.0.26677 build 5645
  1. Initial release

Use Cases
------------
Testing your connectivity and authorization to use Amazon SES. I originally wrote this for use at work since I needed to do quite a bit of firewall testing and I was tired of configuring full services just to test e-mail.
