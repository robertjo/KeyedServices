# KeyedServices

Demo in .NET 8 and C# of **keyed services**.

# Background

Multiple service instances of the same service type can be registered, 
but will have the same implementation type. In the scenario below, the implementation will be the last one registered, `SmsNotificationService`.

```C#
  builder.Services.AddScoped<INotificationService, EmailNotificationService>();
  builder.Services.AddScoped<INotificationService, PushNotificationService>();
  builder.Services.AddScoped<INotificationService, SmsNotificationService>();
```
In this class,  `INotificationService` will have the `SmsNotificationService` implementation.
```C#
public class MessageService(
    INotificationService notificationService)
    : IMessageService
```
