using static ApiNameParts;

readonly struct ApiNames
{
    public const string ApiCalls = api + dot + calls;

    const string format = nameof(format);

    const string calls = nameof(calls);

    const string router = nameof(router);

    const string routes = nameof(routes);

    public const string ApiCallMap = api + dot + calls + dot + "map";

    public const string ApiCallRoutes = api + dot + calls + dot + routes;
}