namespace mtmk.dummy;

/// <summary>
/// Complex Maths operations.
/// </summary>
public class ComplexMaths
{
    /// <summary>
    /// Adds two complex numbers.
    /// </summary>
    /// <param name="a">The first complex number.</param>
    /// <param name="b">The second complex number.</param>
    /// <returns>The sum of the two complex numbers.</returns>
    public Complex Add(Complex a, Complex b) => a + b;
}

/// <summary>
/// Represents a complex number with real and imaginary parts.
/// </summary>
/// <remarks>
/// A complex number consists of a real part and an imaginary part.
/// The real part represents the real magnitude of the number,
/// while the imaginary part represents the imaginary magnitude.
/// </remarks>
public readonly struct Complex {
    /// <summary>
    /// Represents a complex number with real and imaginary parts.
    /// </summary>
    /// <remarks>
    /// A complex number consists of a real part and an imaginary part.
    /// The real part represents the real size of the number,
    /// while the imaginary part represents the imaginary magnitude.
    /// </remarks>
    public int Real { get; }

    /// <summary>
    /// Represents the imaginary part of a complex number.
    /// </summary>
    /// <remarks>
    /// The imaginary part of a complex number represents the magnitude of the imaginary component.
    /// </remarks>
    public int Imaginary { get; }

    /// <summary>
    /// Represents a complex number with real and imaginary parts.
    /// </summary>
    /// <remarks>
    /// A complex number consists of a real part and an imaginary part.
    /// The real part represents the real magnitude of the number,
    /// while the imaginary part represents the imaginary magnitude.
    /// </remarks>
    public Complex(int real, int imaginary)
    {
        this.Real = real;
        this.Imaginary = imaginary;
    }

    /// <summary>
    /// Represents a class that provides complex mathematical operations.
    /// </summary>
    public static Complex operator +(Complex one, Complex two)
    {
        return new Complex(one.Real + two.Real, one.Imaginary + two.Imaginary);
    }

    /// <summary>
    /// Converts the value of the current instance to its equivalent string representation.
    /// </summary>
    /// <returns>A string that represents the current instance.</returns>
    /// <remarks>
    /// This method is used to convert the value of the current instance to its equivalent string representation.
    /// The string representation is in the format "Real + Imaginary i" where Real represents the real part of the complex number
    /// and Imaginary represents the imaginary part of the complex number.
    /// For example, if the real part is 5 and the imaginary part is 8, the result will be "5 + 8i".
    /// </remarks>
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}
