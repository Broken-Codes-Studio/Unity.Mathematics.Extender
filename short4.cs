using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics.Extender
{

    /// <summary>A 4 component vector of shorts.</summary>
    [DebuggerTypeProxy(typeof(short4.DebuggerProxy))]
    [System.Serializable]
    public partial struct short4 : System.IEquatable<short4>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public short x;
        /// <summary>y component of the vector.</summary>
        public short y;
        /// <summary>z component of the vector.</summary>
        public short z;
        /// <summary>w component of the vector.</summary>
        public short w;

        /// <summary>short4 zero value.</summary>
        public static readonly short4 zero;

        /// <summary>Constructs a short4 vector from four short values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short x, short y, short z, short w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a short4 vector from four byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(byte x, byte y, byte z, byte w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a short4 vector from four int values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(int x, int y, int z, int w)
        {
            this.x = (short)x;
            this.y = (short)y;
            this.z = (short)z;
            this.w = (short)w;
        }

        /// <summary>Constructs a short4 vector from two short values and a short2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short x, short y, short2 zw)
        {
            this.x = x;
            this.y = y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a short4 vector from a short value, a short2 vector and a short value.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short x, short2 yz, short w)
        {
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
            this.w = w;
        }

        /// <summary>Constructs a short4 vector from a short value and a short3 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yzw">The constructed vector's yzw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short x, short3 yzw)
        {
            this.x = x;
            this.y = yzw.x;
            this.z = yzw.y;
            this.w = yzw.z;
        }

        /// <summary>Constructs a short4 vector from a short2 vector and two short values.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short2 xy, short z, short w)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
            this.w = w;
        }

        /// <summary>Constructs a short4 vector from two short2 vectors.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short2 xy, short2 zw)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = zw.x;
            this.w = zw.y;
        }

        /// <summary>Constructs a short4 vector from a short3 vector and a short value.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short3 xyz, short w)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
            this.w = w;
        }

        /// <summary>Constructs a short4 vector from a short4 vector.</summary>
        /// <param name="xyzw">The constructed vector's xyzw components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short4 xyzw)
        {
            this.x = xyzw.x;
            this.y = xyzw.y;
            this.z = xyzw.z;
            this.w = xyzw.w;
        }

        /// <summary>Constructs a short4 vector from a single short value by assigning it to every component.</summary>
        /// <param name="v">short to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(short v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a short4 vector from a single byte value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">byte to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(byte v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }

        /// <summary>Constructs a short4 vector from a byte4 vector by componentwise conversion.</summary>
        /// <param name="v">byte4 to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(byte4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        /// <summary>Constructs a short4 vector from a single int value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">int to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(int v)
        {
            this.x = (short)v;
            this.y = (short)v;
            this.z = (short)v;
            this.w = (short)v;
        }

        /// <summary>Constructs a short4 vector from an int4 vector by componentwise conversion.</summary>
        /// <param name="v">int4 to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(int4 v)
        {
            this.x = (short)v.x;
            this.y = (short)v.y;
            this.z = (short)v.z;
            this.w = (short)v.w;
        }

        /// <summary>Constructs a short4 vector from a single float value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">float to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(float v)
        {
            this.x = (short)v;
            this.y = (short)v;
            this.z = (short)v;
            this.w = (short)v;
        }

        /// <summary>Constructs a short4 vector from a float4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(float4 v)
        {
            this.x = (short)v.x;
            this.y = (short)v.y;
            this.z = (short)v.z;
            this.w = (short)v.w;
        }

        /// <summary>Constructs a short4 vector from a single double value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">double to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(double v)
        {
            this.x = (short)v;
            this.y = (short)v;
            this.z = (short)v;
            this.w = (short)v;
        }

        /// <summary>Constructs a short4 vector from a double4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to short4</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public short4(double4 v)
        {
            this.x = (short)v.x;
            this.y = (short)v.y;
            this.z = (short)v.z;
            this.w = (short)v.w;
        }


        /// <summary>Implicitly converts a single short value to a short4 vector by assigning it to every component.</summary>
        /// <param name="v">short to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator short4(short v) { return new short4(v); }

        /// <summary>Explicitly converts a single byte value to a short4 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">byte to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(byte v) { return new short4(v); }

        /// <summary>Explicitly converts a byte4 vector to a short4 vector by componentwise conversion.</summary>
        /// <param name="v">byte4 to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(byte4 v) { return new short4(v); }

        /// <summary>Explicitly converts a single int value to a short4 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">int to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(int v) { return new short4(v); }

        /// <summary>Explicitly converts an int4 vector to a short4 vector by componentwise conversion.</summary>
        /// <param name="v">int4 to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(int4 v) { return new short4(v); }

        /// <summary>Explicitly converts a single float value to a short4 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">float to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(float v) { return new short4(v); }

        /// <summary>Explicitly converts a float4 vector to a short4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(float4 v) { return new short4(v); }

        /// <summary>Explicitly converts a single double value to a short4 vector by converting it to short and assigning it to every component.</summary>
        /// <param name="v">double to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(double v) { return new short4(v); }

        /// <summary>Explicitly converts a double4 vector to a short4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator short4(double4 v) { return new short4(v); }

        /// <summary>Returns the result of a componentwise multiplication operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise multiplication.</param>
        /// <returns>short4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator *(short4 lhs, short4 rhs) { return new short4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w); }

        /// <summary>Returns the result of a componentwise multiplication operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise multiplication.</param>
        /// <returns>short4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator *(short4 lhs, int rhs) { return new short4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise multiplication.</param>
        /// <returns>short4 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator *(int lhs, short4 rhs) { return new short4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w); }


        /// <summary>Returns the result of a componentwise addition operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise addition.</param>
        /// <returns>short4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator +(short4 lhs, short4 rhs) { return new short4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w); }

        /// <summary>Returns the result of a componentwise addition operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise addition.</param>
        /// <returns>short4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator +(short4 lhs, int rhs) { return new short4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise addition.</param>
        /// <returns>short4 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator +(int lhs, short4 rhs) { return new short4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w); }


        /// <summary>Returns the result of a componentwise subtraction operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise subtraction.</param>
        /// <returns>short4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator -(short4 lhs, short4 rhs) { return new short4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w); }

        /// <summary>Returns the result of a componentwise subtraction operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise subtraction.</param>
        /// <returns>short4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator -(short4 lhs, int rhs) { return new short4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise subtraction.</param>
        /// <returns>short4 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator -(int lhs, short4 rhs) { return new short4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w); }


        /// <summary>Returns the result of a componentwise division operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise division.</param>
        /// <returns>short4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator /(short4 lhs, short4 rhs) { return new short4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w); }

        /// <summary>Returns the result of a componentwise division operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise division.</param>
        /// <returns>short4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator /(short4 lhs, int rhs) { return new short4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise division.</param>
        /// <returns>short4 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator /(int lhs, short4 rhs) { return new short4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w); }


        /// <summary>Returns the result of a componentwise modulus operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise modulus.</param>
        /// <returns>short4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator %(short4 lhs, short4 rhs) { return new short4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w); }

        /// <summary>Returns the result of a componentwise modulus operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise modulus.</param>
        /// <returns>short4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator %(short4 lhs, int rhs) { return new short4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise modulus.</param>
        /// <returns>short4 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator %(int lhs, short4 rhs) { return new short4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w); }


        /// <summary>Returns the result of a componentwise increment operation on an short4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>short4 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator ++(short4 val) { return new short4(++val.x, ++val.y, ++val.z, ++val.w); }


        /// <summary>Returns the result of a componentwise decrement operation on an short4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>short4 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator --(short4 val) { return new short4(--val.x, --val.y, --val.z, --val.w); }


        /// <summary>Returns the result of a componentwise less than operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <(short4 lhs, short4 rhs) { return new bool4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w); }

        /// <summary>Returns the result of a componentwise less than operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <(short4 lhs, int rhs) { return new bool4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise less than.</param>
        /// <returns>bool4 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <(int lhs, short4 rhs) { return new bool4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w); }


        /// <summary>Returns the result of a componentwise less or equal operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <=(short4 lhs, short4 rhs) { return new bool4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w); }

        /// <summary>Returns the result of a componentwise less or equal operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <=(short4 lhs, int rhs) { return new bool4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise less or equal.</param>
        /// <returns>bool4 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator <=(int lhs, short4 rhs) { return new bool4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w); }


        /// <summary>Returns the result of a componentwise greater than operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >(short4 lhs, short4 rhs) { return new bool4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w); }

        /// <summary>Returns the result of a componentwise greater than operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >(short4 lhs, int rhs) { return new bool4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise greater than.</param>
        /// <returns>bool4 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >(int lhs, short4 rhs) { return new bool4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >=(short4 lhs, short4 rhs) { return new bool4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an short4 vector and an int value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >=(short4 lhs, int rhs) { return new bool4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an short4 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise greater or equal.</param>
        /// <returns>bool4 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator >=(int lhs, short4 rhs) { return new bool4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w); }


        /// <summary>Returns the result of a componentwise unary minus operation on an short4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>short4 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator -(short4 val) { return new short4(-val.x, -val.y, -val.z, -val.w); }


        /// <summary>Returns the result of a componentwise unary plus operation on an short4 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>short4 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator +(short4 val) { return new short4(+val.x, +val.y, +val.z, +val.w); }


        /// <summary>Returns the result of a componentwise left shift operation on an short4 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator <<(short4 x, int n) { return new short4(x.x << n, x.y << n, x.z << n, x.w << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an short4 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 operator >>(short4 x, int n) { return new short4(x.x >> n, x.y >> n, x.z >> n, x.w >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (short4 lhs, short4 rhs) { return new bool4 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w); }

        /// <summary>Returns the result of a componentwise equality operation on a short4 vector and a short value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side short to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (short4 lhs, short rhs) { return new bool4 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a short value and a short4 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise equality.</param>
        /// <returns>bool4 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator == (short lhs, short4 rhs) { return new bool4 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w); }


        /// <summary>Returns the result of a componentwise not equal operation on two short4 vectors.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (short4 lhs, short4 rhs) { return new bool4 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w); }

        /// <summary>Returns the result of a componentwise not equal operation on a short4 vector and a short value.</summary>
        /// <param name="lhs">Left hand side short4 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side short to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (short4 lhs, short rhs) { return new bool4 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a short value and a short4 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side short4 to use to compute componentwise not equal.</param>
        /// <returns>bool4 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool4 operator != (short lhs, short4 rhs) { return new bool4 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w); }




        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 xwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(x, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 yzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 ywww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(y, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; w = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 zwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(z, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wxww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; z = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wyww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; y = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; x = value.w; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wzww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short4 wwww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short4(w, w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 xww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(x, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 ywx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 ywy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 ywz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 yww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(y, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; w = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 zww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(z, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wxw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, x, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wyw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, y, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wzw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, z, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wwx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, w, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wwy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, w, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 wwz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, w, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short3 www
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short3(w, w, w); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 xw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(x, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; w = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 yw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(y, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; w = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 zw
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(z, w); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; w = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 wx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(w, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 wy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(w, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 wz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(w, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { w = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public short2 ww
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new short2(w, w); }
        }



        /// <summary>Returns the short element at a specified index.</summary>
        unsafe public short this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (short4* array = &this) { return ((short*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 4)
                    throw new System.ArgumentException("index must be between[0...3]");
#endif
                fixed (short* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the short4 is equal to a given short4, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(short4 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z && w == rhs.w; }

        /// <summary>Returns true if the short4 is equal to a given short4, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is short4 converted && Equals(converted); }


        /// <summary>Returns a hash code for the short4.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)mathExtended.hash(this); }


        /// <summary>Returns a string representation of the short4.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("short4({0}, {1}, {2}, {3})", x, y, z, w);
        }

        /// <summary>Returns a string representation of the short4 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("short4({0}, {1}, {2}, {3})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider), w.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public short x;
            public short y;
            public short z;
            public short w;
            public DebuggerProxy(short4 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
                w = v.w;
            }
        }

    }

    public static partial class mathExtended
    {
        /// <summary>Returns a short4 vector constructed from four short values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>short4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short x, short y, short z, short w) { return new short4(x, y, z, w); }

        /// <summary>Returns a short4 vector constructed from two short values and a short2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        /// <returns>short4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short x, short y, short2 zw) { return new short4(x, y, zw); }

        /// <summary>Returns a short4 vector constructed from a short value, a short2 vector and a short value.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>short4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short x, short2 yz, short w) { return new short4(x, yz, w); }

        /// <summary>Returns a short4 vector constructed from a short value and a short3 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yzw">The constructed vector's yzw components will be set to this value.</param>
        /// <returns>short4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short x, short3 yzw) { return new short4(x, yzw); }

        /// <summary>Returns a short4 vector constructed from a short2 vector and two short values.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>short4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short2 xy, short z, short w) { return new short4(xy, z, w); }

        /// <summary>Returns a short4 vector constructed from two short2 vectors.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="zw">The constructed vector's zw components will be set to this value.</param>
        /// <returns>short4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short2 xy, short2 zw) { return new short4(xy, zw); }

        /// <summary>Returns a short4 vector constructed from a short3 vector and a short value.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <param name="w">The constructed vector's w component will be set to this value.</param>
        /// <returns>short4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short3 xyz, short w) { return new short4(xyz, w); }

        /// <summary>Returns a short4 vector constructed from a short4 vector.</summary>
        /// <param name="xyzw">The constructed vector's xyzw components will be set to this value.</param>
        /// <returns>short4 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short4 xyzw) { return new short4(xyzw); }

        /// <summary>Returns a short4 vector constructed from a single short value by assigning it to every component.</summary>
        /// <param name="v">short to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(short v) { return new short4(v); }

        /// <summary>Returns a short4 vector constructed from a single float value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">float to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(float v) { return new short4(v); }

        /// <summary>Return a short4 vector constructed from a float4 vector by componentwise conversion.</summary>
        /// <param name="v">float4 to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(float4 v) { return new short4(v); }

        /// <summary>Returns a short4 vector constructed from a single double value by converting it to short and assigning it to every component.</summary>
        /// <param name="v">double to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(double v) { return new short4(v); }

        /// <summary>Return a short4 vector constructed from a double4 vector by componentwise conversion.</summary>
        /// <param name="v">double4 to convert to short4</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static short4 short4(double4 v) { return new short4(v); }

        /// <summary>Returns a uint hash code of a short4 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(short4 v)
        {
            return Mathematics.math.csum(new uint4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w) * new uint4(0x745ED837u, 0x9CDC88F5u, 0xFA62D721u, 0x7E4DB1CFu)) + 0x68EEE0F5u;
        }

        /// <summary>
        /// Returns a uint4 vector hash code of a short4 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint4 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 hashwide(short4 v)
        {
            return (new uint4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w) * new uint4(0xBC3B0A59u, 0x816EFB5Du, 0xA24E82B7u, 0x45A22087u)) + 0xFC104C3Bu;
        }

    }
}
