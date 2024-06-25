namespace mtmk.dummy;

/// <summary>
/// Represents a simple text.
/// </summary>
public class SimpleText
{
    /// <summary>
    /// Turn a string to uppercase.
    /// </summary>
    /// <param name="input">String to input</param>
    /// <returns>The uppercase version of it, of course.</returns>
    public string UpperCase(string input) => input.ToUpper();

    /// <summary>
    /// Turn a string to lowercase.
    /// </summary>
    /// <param name="input">String to input</param>
    /// <returns>The lowercase version silly!</returns>
    public string LowerCase(string input) => input.ToLower();
}