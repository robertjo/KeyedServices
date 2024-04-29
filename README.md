# Keyed Services

Demo in .NET 8 and C# of **keyed services**.

# Background

In .NET, it's possible to register multiple service instances of the same service type,
though these will have the same implementation type.

In the scenario below, the implementation type will be that of the last one registered, `SmsNotificationService`.

```C#
  builder.Services.AddScoped<INotificationService, EmailNotificationService>();
  builder.Services.AddScoped<INotificationService, PushNotificationService>();
  builder.Services.AddScoped<INotificationService, SmsNotificationService>();
```
In this class,  `INotificationService` will use the `SmsNotificationService` implementation.
```C#
public class MessageService(
    INotificationService notificationService)
    : IMessageService
```
# Keyed Services

In .NET 8, it's possible to register multiple services with a different key, and use this key for the lookup.
New extension methods have been added to IServiceCollection to support keyed services, for example, `AddKeyedScoped`.

```C#
  builder.Services.AddKeyedScoped<INotificationService, EmailNotificationService>(Keys.Email);
  builder.Services.AddKeyedScoped<INotificationService, PushNotificationService>(Keys.Push);
  builder.Services.AddKeyedScoped<INotificationService, SmsNotificationService>(Keys.Sms);
```

By using the `[FromKeyedServices]` attribute in this class, `INotificationService` will use the `EmailNotificationService` implementation.

```C#
public class EmailMessageService(
    [FromKeyedServices(Keys.Email)] INotificationService notificationService)
    : IMessageService
```
