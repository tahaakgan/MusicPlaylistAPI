using Microsoft.AspNetCore.Localization;

namespace MusicPlaylistApi.Middlewares;

public class RequestLoggingMiddleware
{
    private readonly RequestDelegate _next;

    public RequestLoggingMiddleware(RequestDelegate next) {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext context) {
        Console.WriteLine($"İstek geldi: {context.Request.Method} {context.Request.Path}");

        await _next(context);

        Console.WriteLine($"Yanit gönderildi: {context.Response.StatusCode}");
    }
}
