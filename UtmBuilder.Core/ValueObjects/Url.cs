using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects;

public class Url : ValueObjects
{
    /// <summary>
    /// Create a new URL
    /// </summary>
    /// <param name="address">address of URL (Website link)</param>
    public Url(string address)
    {
        Address = address;
        InvalidUrlException.ThrowIfInvalid(Address);
    }

    /// <summary>
    /// address of URL (Website link)
    /// </summary>
    public string Address { get; }
}