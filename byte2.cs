using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics.Extender
{
    /// <summary>A 2 component vector of bytes.</summary>
    [DebuggerTypeProxy(typeof(byte2.DebuggerProxy))]
    [System.Serializable]
    public partial struct byte2 : System.IEquatable<byte2>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public byte x;
        /// <summary>y component of the vector.</summary>
        public byte y;

        /// <summary>byte2 zero value.</summary>
        public static readonly byte2 zero;

        /// <summary>Constructs a byte2 vector from two byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(byte x, byte y)
        {
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a byte2 vector from two int values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(int x, int y)
        {
            this.x = (byte)x;
            this.y = (byte)y;
        }

        /// <summary>Constructs a byte2 vector from a byte2 vector.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(byte2 xy)
        {
            this.x = xy.x;
            this.y = xy.y;
        }

        /// <summary>Constructs a byte2 vector from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(byte v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a int2 vector from a single bool value by converting it to int and assigning it to every component.</summary>
        /// <param name="v">bool to convert to int2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(bool v)
        {
            this.x = (byte)(v ? 1 : 0);
            this.y = (byte)(v ? 1 : 0);
        }

        /// <summary>Constructs a byte2 vector from a single short value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">short to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(short v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
        }

        /// <summary>Constructs a byte2 vector from a short2 vector by componentwise conversion.</summary>
        /// <param name="v">short2 to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(short2 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
        }

        /// <summary>Constructs a byte2 vector from a single int value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">int to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(int v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
        }

        /// <summary>Constructs a byte2 vector from an int2 vector by componentwise conversion.</summary>
        /// <param name="v">int2 to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(int2 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
        }


        /// <summary>Constructs a byte2 vector from a single float value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">float to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(float v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
        }

        /// <summary>Constructs a byte2 vector from a float2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(float2 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
        }

        /// <summary>Constructs a byte2 vector from a single double value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">double to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(double v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
        }

        /// <summary>Constructs a byte2 vector from a double2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to byte2</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte2(double2 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
        }


        /// <summary>Implicitly converts a single byte value to a byte2 vector by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte2(byte v) { return new byte2(v); }

        /// <summary>Explicitly converts a single int value to a byte2 vector by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">int to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(int v) { return new byte2(v); }

        /// <summary>Explicitly converts a int2 vector to a byte2 vector by componentwise conversion.</summary>
        /// <param name="v">int2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(int2 v) { return new byte2(v); }

        /// <summary>Explicitly converts a single float value to a byte2 vector by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">float to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(float v) { return new byte2(v); }

        /// <summary>Explicitly converts a float2 vector to a byte2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(float2 v) { return new byte2(v); }

        /// <summary>Explicitly converts a single double value to a byte2 vector by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">double to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(double v) { return new byte2(v); }

        /// <summary>Explicitly converts a double2 vector to a byte2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte2(double2 v) { return new byte2(v); }

        /// <summary>Returns the result of a componentwise multiplication operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise multiplication.</param>
        /// <returns>byte2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator *(byte2 lhs, byte2 rhs) { return new byte2(lhs.x * rhs.x, lhs.y * rhs.y); }

        /// <summary>Returns the result of a componentwise multiplication operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise multiplication.</param>
        /// <returns>byte2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator *(byte2 lhs, int rhs) { return new byte2(lhs.x * rhs, lhs.y * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise multiplication.</param>
        /// <returns>byte2 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator *(int lhs, byte2 rhs) { return new byte2(lhs * rhs.x, lhs * rhs.y); }


        /// <summary>Returns the result of a componentwise addition operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise addition.</param>
        /// <returns>byte2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator +(byte2 lhs, byte2 rhs) { return new byte2(lhs.x + rhs.x, lhs.y + rhs.y); }

        /// <summary>Returns the result of a componentwise addition operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise addition.</param>
        /// <returns>byte2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator +(byte2 lhs, int rhs) { return new byte2(lhs.x + rhs, lhs.y + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise addition.</param>
        /// <returns>byte2 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator +(int lhs, byte2 rhs) { return new byte2(lhs + rhs.x, lhs + rhs.y); }


        /// <summary>Returns the result of a componentwise subtraction operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise subtraction.</param>
        /// <returns>byte2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator -(byte2 lhs, byte2 rhs) { return new byte2(lhs.x - rhs.x, lhs.y - rhs.y); }

        /// <summary>Returns the result of a componentwise subtraction operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise subtraction.</param>
        /// <returns>byte2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator -(byte2 lhs, int rhs) { return new byte2(lhs.x - rhs, lhs.y - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise subtraction.</param>
        /// <returns>byte2 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator -(int lhs, byte2 rhs) { return new byte2(lhs - rhs.x, lhs - rhs.y); }


        /// <summary>Returns the result of a componentwise division operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise division.</param>
        /// <returns>byte2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator /(byte2 lhs, byte2 rhs) { return new byte2(lhs.x / rhs.x, lhs.y / rhs.y); }

        /// <summary>Returns the result of a componentwise division operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise division.</param>
        /// <returns>byte2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator /(byte2 lhs, int rhs) { return new byte2(lhs.x / rhs, lhs.y / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise division.</param>
        /// <returns>byte2 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator /(int lhs, byte2 rhs) { return new byte2(lhs / rhs.x, lhs / rhs.y); }


        /// <summary>Returns the result of a componentwise modulus operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise modulus.</param>
        /// <returns>byte2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator %(byte2 lhs, byte2 rhs) { return new byte2(lhs.x % rhs.x, lhs.y % rhs.y); }

        /// <summary>Returns the result of a componentwise modulus operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise modulus.</param>
        /// <returns>byte2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator %(byte2 lhs, int rhs) { return new byte2(lhs.x % rhs, lhs.y % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise modulus.</param>
        /// <returns>byte2 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator %(int lhs, byte2 rhs) { return new byte2(lhs % rhs.x, lhs % rhs.y); }


        /// <summary>Returns the result of a componentwise increment operation on an byte2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>byte2 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator ++(byte2 val) { return new byte2(++val.x, ++val.y); }


        /// <summary>Returns the result of a componentwise decrement operation on an byte2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>byte2 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator --(byte2 val) { return new byte2(--val.x, --val.y); }


        /// <summary>Returns the result of a componentwise less than operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise less than.</param>
        /// <returns>bool2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <(byte2 lhs, byte2 rhs) { return new bool2(lhs.x < rhs.x, lhs.y < rhs.y); }

        /// <summary>Returns the result of a componentwise less than operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise less than.</param>
        /// <returns>bool2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <(byte2 lhs, int rhs) { return new bool2(lhs.x < rhs, lhs.y < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise less than.</param>
        /// <returns>bool2 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <(int lhs, byte2 rhs) { return new bool2(lhs < rhs.x, lhs < rhs.y); }


        /// <summary>Returns the result of a componentwise less or equal operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise less or equal.</param>
        /// <returns>bool2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <=(byte2 lhs, byte2 rhs) { return new bool2(lhs.x <= rhs.x, lhs.y <= rhs.y); }

        /// <summary>Returns the result of a componentwise less or equal operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise less or equal.</param>
        /// <returns>bool2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <=(byte2 lhs, int rhs) { return new bool2(lhs.x <= rhs, lhs.y <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise less or equal.</param>
        /// <returns>bool2 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <=(int lhs, byte2 rhs) { return new bool2(lhs <= rhs.x, lhs <= rhs.y); }


        /// <summary>Returns the result of a componentwise greater than operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise greater than.</param>
        /// <returns>bool2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >(byte2 lhs, byte2 rhs) { return new bool2(lhs.x > rhs.x, lhs.y > rhs.y); }

        /// <summary>Returns the result of a componentwise greater than operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise greater than.</param>
        /// <returns>bool2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >(byte2 lhs, int rhs) { return new bool2(lhs.x > rhs, lhs.y > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise greater than.</param>
        /// <returns>bool2 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >(int lhs, byte2 rhs) { return new bool2(lhs > rhs.x, lhs > rhs.y); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise greater or equal.</param>
        /// <returns>bool2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >=(byte2 lhs, byte2 rhs) { return new bool2(lhs.x >= rhs.x, lhs.y >= rhs.y); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an byte2 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise greater or equal.</param>
        /// <returns>bool2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >=(byte2 lhs, int rhs) { return new bool2(lhs.x >= rhs, lhs.y >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an byte2 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise greater or equal.</param>
        /// <returns>bool2 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >=(int lhs, byte2 rhs) { return new bool2(lhs >= rhs.x, lhs >= rhs.y); }


        /// <summary>Returns the result of a componentwise unary minus operation on an byte2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>byte2 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator -(byte2 val) { return new byte2(-val.x, -val.y); }


        /// <summary>Returns the result of a componentwise unary plus operation on an byte2 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>byte2 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator +(byte2 val) { return new byte2(+val.x, +val.y); }


        /// <summary>Returns the result of a componentwise left shift operation on an byte2 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator <<(byte2 x, int n) { return new byte2(x.x << n, x.y << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an byte2 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 operator >>(byte2 x, int n) { return new byte2(x.x >> n, x.y >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (byte2 lhs, byte2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on a byte2 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (byte2 lhs, byte rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a byte value and a byte2 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise equality.</param>
        /// <returns>bool2 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (byte lhs, byte2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two byte2 vectors.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (byte2 lhs, byte2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on a byte2 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte2 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (byte2 lhs, byte rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a byte value and a byte2 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte2 to use to compute componentwise not equal.</param>
        /// <returns>bool2 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (byte lhs, byte2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }




        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(y, y); }
        }



        /// <summary>Returns the byte element at a specified index.</summary>
        unsafe public byte this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (byte2* array = &this) { return ((byte*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (byte* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the byte2 is equal to a given byte2, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(byte2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the byte2 is equal to a given byte2, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is byte2 converted && Equals(converted); }


        /// <summary>Returns a hash code for the byte2.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)mathExtended.hash(this); }


        /// <summary>Returns a string representation of the byte2.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("byte2({0}, {1})", x, y);
        }

        /// <summary>Returns a string representation of the byte2 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("byte2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public byte x;
            public byte y;
            public DebuggerProxy(byte2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class mathExtended
    {
        /// <summary>Returns a byte2 vector constructed from two byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <returns>byte2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 byte2(byte x, byte y) { return new byte2(x, y); }

        /// <summary>Returns a byte2 vector constructed from a byte2 vector.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <returns>byte2 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 byte2(byte2 xy) { return new byte2(xy); }

        /// <summary>Returns a byte2 vector constructed from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 byte2(byte v) { return new byte2(v); }

        /// <summary>Returns a byte2 vector constructed from a single float value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">float to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 byte2(float v) { return new byte2(v); }

        /// <summary>Return a byte2 vector constructed from a float2 vector by componentwise conversion.</summary>
        /// <param name="v">float2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 byte2(float2 v) { return new byte2(v); }

        /// <summary>Returns a byte2 vector constructed from a single double value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">double to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 byte2(double v) { return new byte2(v); }

        /// <summary>Return a byte2 vector constructed from a double2 vector by componentwise conversion.</summary>
        /// <param name="v">double2 to convert to byte2</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte2 byte2(double2 v) { return new byte2(v); }

        /// <summary>Returns a uint hash code of a byte2 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(byte2 v)
        {
            return Mathematics.math.csum(new uint2((uint)v.x, (uint)v.y) * new uint2(0x6E624EB7u, 0x7383ED49u)) + 0xDD49C23Bu;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a byte2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint2 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(byte2 v)
        {
            return (new uint2((uint)v.x, (uint)v.y) * new uint2(0xEBD0D005u, 0x91475DF7u)) + 0x55E84827u;
        }

    }
}
