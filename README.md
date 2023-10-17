# Windows.Service.NET6
A Windows service that will write in a file with a time interval
Publish the project then create a Windows service by following command:

The below path from the publish folder.
sc create MyService binpath= "D:\ServicePublish\PublishWithFile\WorkerService1.exe"

      #Install	: SC CREATE "MyService" binpath= "D:\wwwroot\Services\GoogleNotification.Service\selfcare.Service.exe"

      
      #Unstall	: SC DELETE "MyService"
      
      #Start		: net start MyService

      
      #Stop		: net stop MyService

      
       #Kill		: Taskkill /PID 12068 /F
