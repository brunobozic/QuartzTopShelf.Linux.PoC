# Quartz Topshelf Proof of Concept for Linux
##
###

- Aye it is 4.2.0, but going throu API of the host factory I came upon UseEnvironmentBuilder 
  (well this method is not described in offical documentation, like it does not exists) in description it says that default value 
  is WindowsHostEnvironmentBuilder, and when i changed that to DotNetCoreEnvironmentBuilder it worked on Linux.
   Wojciech Szabowicz Jun 26 '19 at 6:12

- https://sibeeshpassion.com/asp-net-core-windows-service-task-quartz-net-with-database/
- https://github.com/jlucansky/Quartzmin
- https://github.com/DanielOliver/Topshelf-Quartz/blob/master/Vagrantfile