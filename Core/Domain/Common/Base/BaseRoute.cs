namespace Top.MasonTech.NetCoreBaseAPI.Core.Domain.Common.Base;

/// <summary>
/// Base route for common use. If other class use, need to keep structure
/// </summary>
public class BaseRoute
{
    public const string Name = "base";

    protected BaseRoute() { }

    public class BaseRouteV1
    {
        public const string Search = Version + "/search";
        public const string Create = Version + "/create";
        public const string Update = Version + "/update/{id}";
        public const string Delete = Version + "/delete/{id}";
        private const string Version = "v1";

        protected BaseRouteV1() { }
    }
}
