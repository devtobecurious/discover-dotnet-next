namespace TestFilterMinimalApi.Filters
{
    public class LogMoreFilter : IEndpointFilter
    {
        protected readonly ILogger Logger;
        private readonly string _methodName;

        public LogMoreFilter(ILoggerFactory loggerFactory)
        {
            LoggerFactory = loggerFactory;
            Logger = loggerFactory.CreateLogger<LogMoreFilter>();
            _methodName = GetType().Name;
        }

        public ILoggerFactory LoggerFactory { get; }

        public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
        {
            Logger.LogInformation("{MethodName} Before next", _methodName);
            var result = await next(context);
            Logger.LogInformation("{MethodName} After next", _methodName);
            return result;
        }
    }
}
