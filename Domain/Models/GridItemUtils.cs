using System.Reflection;

namespace BlazorTutorial.Models;

public static class GridItemUtils
{
    public static object GetPropValue(this object src, string propName)
    {
        return src.GetType().GetProperty(propName).GetValue(src, null);
    }
}