using Koffee.Context;

namespace Koffee;

public class Helper
{
    private static MyDbContext _satellitecontext;
    public static MyDbContext GetContext()
    {
        return _satellitecontext ??= new();
    }
}