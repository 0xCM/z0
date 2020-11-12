using static ApiNameParts;

readonly struct ApiNames
{
    public const string ApiSpecs = api + dot + specs;

    const string format = nameof(format);

    const string calls = nameof(calls);

    const string router = nameof(router);

    const string routes = nameof(routes);

    const string actions = nameof(actions);

    const string functions = nameof(functions);

    const string operations = nameof(operations);

    public const string ApiCallMap = api + dot + calls + dot + "map";

    public const string ApiCallRoutes = api + dot + calls + dot + routes;

    public const string ApiData = api + dot + data;

    public const string ApiRuntime = api + dot + runtime;

    public const string ApiSigs = api + dot + signatures;


}