using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics.Extender
{
    /// <summary>A 3 component vector of bytes.</summary>
    [DebuggerTypeProxy(typeof(byte3.DebuggerProxy))]
    [System.Serializable]
    public partial struct byte3 : System.IEquatable<byte3>, IFormattable
    {
        /// <summary>x component of the vector.</summary>
        public byte x;
        /// <summary>y component of the vector.</summary>
        public byte y;
        /// <summary>z component of the vector.</summary>
        public byte z;

        /// <summary>byte3 zero value.</summary>
        public static readonly byte3 zero;

        /// <summary>Constructs a byte3 vector from three byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(byte x, byte y, byte z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        /// <summary>Constructs a byte3 vector from three int values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(int x, int y, int z)
        {
            this.x = (byte)x;
            this.y = (byte)y;
            this.z = (byte)z;
        }

        /// <summary>Constructs a byte3 vector from a byte value and a byte2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(byte x, byte2 yz)
        {
            this.x = x;
            this.y = yz.x;
            this.z = yz.y;
        }

        /// <summary>Constructs a byte3 vector from a byte2 vector and a byte value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(byte2 xy, byte z)
        {
            this.x = xy.x;
            this.y = xy.y;
            this.z = z;
        }

        /// <summary>Constructs a byte3 vector from a byte3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(byte3 xyz)
        {
            this.x = xyz.x;
            this.y = xyz.y;
            this.z = xyz.z;
        }

        /// <summary>Constructs a byte3 vector from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(byte v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }

        /// <summary>Constructs a byte3 vector from a single short value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">short to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(short v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
            this.z = (byte)v;
        }

        /// <summary>Constructs a byte3 vector from a short3 vector by componentwise conversion.</summary>
        /// <param name="v">short3 to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(short3 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
            this.z = (byte)v.z;
        }

        /// <summary>Constructs a byte3 vector from a single int value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">int to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(int v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
            this.z = (byte)v;
        }

        /// <summary>Constructs a byte3 vector from an int3 vector by componentwise conversion.</summary>
        /// <param name="v">int3 to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(int3 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
            this.z = (byte)v.z;
        }

        /// <summary>Constructs a byte3 vector from a single float value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">float to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(float v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
            this.z = (byte)v;
        }

        /// <summary>Constructs a byte3 vector from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(float3 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
            this.z = (byte)v.z;
        }

        /// <summary>Constructs a byte3 vector from a single double value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">double to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(double v)
        {
            this.x = (byte)v;
            this.y = (byte)v;
            this.z = (byte)v;
        }

        /// <summary>Constructs a byte3 vector from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to byte3</param>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte3(double3 v)
        {
            this.x = (byte)v.x;
            this.y = (byte)v.y;
            this.z = (byte)v.z;
        }


        /// <summary>Implicitly converts a single byte value to a byte3 vector by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator byte3(byte v) { return new byte3(v); }

        /// <summary>Explicitly converts a single int value to a byte3 vector by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">int to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(int v) { return new byte3(v); }

        /// <summary>Explicitly converts an int3 vector to a byte3 vector by componentwise conversion.</summary>
        /// <param name="v">int3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(int3 v) { return new byte3(v); }

        /// <summary>Explicitly converts a single float value to a byte3 vector by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">float to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(float v) { return new byte3(v); }

        /// <summary>Explicitly converts a float3 vector to a byte3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(float3 v) { return new byte3(v); }

        /// <summary>Explicitly converts a single double value to a byte3 vector by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">double to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(double v) { return new byte3(v); }

        /// <summary>Explicitly converts a double3 vector to a byte3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator byte3(double3 v) { return new byte3(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise multiplication.</param>
        /// <returns>byte3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator *(byte3 lhs, byte3 rhs) { return new byte3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on an byte3 vector and an byte value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise multiplication.</param>
        /// <returns>byte3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator *(byte3 lhs, byte rhs) { return new byte3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an byte3 vector and an short value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side short to use to compute componentwise multiplication.</param>
        /// <returns>byte3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator *(byte3 lhs, short rhs) { return new byte3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise multiplication.</param>
        /// <returns>byte3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator *(byte3 lhs, int rhs) { return new byte3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on an byte value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise multiplication.</param>
        /// <returns>byte3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator *(byte lhs, byte3 rhs) { return new byte3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on an short value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise multiplication.</param>
        /// <returns>byte3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator *(short lhs, byte3 rhs) { return new byte3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }

        /// <summary>Returns the result of a componentwise multiplication operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise multiplication.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise multiplication.</param>
        /// <returns>byte3 result of the componentwise multiplication.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator *(int lhs, byte3 rhs) { return new byte3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise addition.</param>
        /// <returns>byte3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator +(byte3 lhs, byte3 rhs) { return new byte3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on an byte3 vector and an byte value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise addition.</param>
        /// <returns>byte3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator +(byte3 lhs, byte rhs) { return new byte3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an byte3 vector and an short value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side short to use to compute componentwise addition.</param>
        /// <returns>byte3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator +(byte3 lhs, short rhs) { return new byte3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise addition.</param>
        /// <returns>byte3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator +(byte3 lhs, int rhs) { return new byte3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on an byte value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise addition.</param>
        /// <returns>byte3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator +(byte lhs, byte3 rhs) { return new byte3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on an short value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise addition.</param>
        /// <returns>byte3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator +(short lhs, byte3 rhs) { return new byte3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }

        /// <summary>Returns the result of a componentwise addition operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise addition.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise addition.</param>
        /// <returns>byte3 result of the componentwise addition.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator +(int lhs, byte3 rhs) { return new byte3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z); }


        /// <summary>Returns the result of a componentwise subtraction operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise subtraction.</param>
        /// <returns>byte3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator -(byte3 lhs, byte3 rhs) { return new byte3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on an byte3 vector and an byte value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise subtraction.</param>
        /// <returns>byte3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator -(byte3 lhs, byte rhs) { return new byte3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an byte3 vector and an short value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side short to use to compute componentwise subtraction.</param>
        /// <returns>byte3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator -(byte3 lhs, short rhs) { return new byte3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise subtraction.</param>
        /// <returns>byte3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator -(byte3 lhs, int rhs) { return new byte3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on an byte value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise subtraction.</param>
        /// <returns>byte3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator -(byte lhs, byte3 rhs) { return new byte3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on an short value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise subtraction.</param>
        /// <returns>byte3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator -(short lhs, byte3 rhs) { return new byte3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }

        /// <summary>Returns the result of a componentwise subtraction operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise subtraction.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise subtraction.</param>
        /// <returns>byte3 result of the componentwise subtraction.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator -(int lhs, byte3 rhs) { return new byte3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z); }


        /// <summary>Returns the result of a componentwise division operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise division.</param>
        /// <returns>byte3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator /(byte3 lhs, byte3 rhs) { return new byte3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise division.</param>
        /// <returns>byte3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator /(byte3 lhs, int rhs) { return new byte3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs); }

        /// <summary>Returns the result of a componentwise division operation on an byte value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise division.</param>
        /// <returns>byte3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator /(byte lhs, byte3 rhs) { return new byte3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on an short value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise division.</param>
        /// <returns>byte3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator /(short lhs, byte3 rhs) { return new byte3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }

        /// <summary>Returns the result of a componentwise division operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise division.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise division.</param>
        /// <returns>byte3 result of the componentwise division.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator /(int lhs, byte3 rhs) { return new byte3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z); }


        /// <summary>Returns the result of a componentwise modulus operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise modulus.</param>
        /// <returns>byte3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator %(byte3 lhs, byte3 rhs) { return new byte3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on an byte3 vector and an byte value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise modulus.</param>
        /// <returns>byte3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator %(byte3 lhs, byte rhs) { return new byte3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an byte3 vector and an short value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side short to use to compute componentwise modulus.</param>
        /// <returns>byte3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator %(byte3 lhs, short rhs) { return new byte3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise modulus.</param>
        /// <returns>byte3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator %(byte3 lhs, int rhs) { return new byte3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on an byte value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise modulus.</param>
        /// <returns>byte3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator %(byte lhs, byte3 rhs) { return new byte3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on an short value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side short to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise modulus.</param>
        /// <returns>byte3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator %(short lhs, byte3 rhs) { return new byte3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }

        /// <summary>Returns the result of a componentwise modulus operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise modulus.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise modulus.</param>
        /// <returns>byte3 result of the componentwise modulus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator %(int lhs, byte3 rhs) { return new byte3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z); }


        /// <summary>Returns the result of a componentwise increment operation on an byte3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise increment.</param>
        /// <returns>byte3 result of the componentwise increment.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator ++(byte3 val) { return new byte3(++val.x, ++val.y, ++val.z); }


        /// <summary>Returns the result of a componentwise decrement operation on an byte3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise decrement.</param>
        /// <returns>byte3 result of the componentwise decrement.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator --(byte3 val) { return new byte3(--val.x, --val.y, --val.z); }


        /// <summary>Returns the result of a componentwise less than operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <(byte3 lhs, byte3 rhs) { return new bool3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z); }

        /// <summary>Returns the result of a componentwise less than operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <(byte3 lhs, int rhs) { return new bool3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise less than.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise less than.</param>
        /// <returns>bool3 result of the componentwise less than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <(int lhs, byte3 rhs) { return new bool3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z); }


        /// <summary>Returns the result of a componentwise less or equal operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <=(byte3 lhs, byte3 rhs) { return new bool3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z); }

        /// <summary>Returns the result of a componentwise less or equal operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <=(byte3 lhs, int rhs) { return new bool3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise less or equal.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise less or equal.</param>
        /// <returns>bool3 result of the componentwise less or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator <=(int lhs, byte3 rhs) { return new bool3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z); }


        /// <summary>Returns the result of a componentwise greater than operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >(byte3 lhs, byte3 rhs) { return new bool3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z); }

        /// <summary>Returns the result of a componentwise greater than operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >(byte3 lhs, int rhs) { return new bool3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise greater than.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise greater than.</param>
        /// <returns>bool3 result of the componentwise greater than.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >(int lhs, byte3 rhs) { return new bool3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >=(byte3 lhs, byte3 rhs) { return new bool3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an byte3 vector and an int value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side int to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >=(byte3 lhs, int rhs) { return new bool3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on an int value and an byte3 vector.</summary>
        /// <param name="lhs">Left hand side int to use to compute componentwise greater or equal.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise greater or equal.</param>
        /// <returns>bool3 result of the componentwise greater or equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator >=(int lhs, byte3 rhs) { return new bool3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z); }


        /// <summary>Returns the result of a componentwise unary minus operation on an byte3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary minus.</param>
        /// <returns>byte3 result of the componentwise unary minus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator -(byte3 val) { return new byte3(-val.x, -val.y, -val.z); }


        /// <summary>Returns the result of a componentwise unary plus operation on an byte3 vector.</summary>
        /// <param name="val">Value to use when computing the componentwise unary plus.</param>
        /// <returns>byte3 result of the componentwise unary plus.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator +(byte3 val) { return new byte3(+val.x, +val.y, +val.z); }


        /// <summary>Returns the result of a componentwise left shift operation on an byte3 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to left shift.</param>
        /// <param name="n">The number of bits to left shift.</param>
        /// <returns>The result of the componentwise left shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator <<(byte3 x, int n) { return new byte3(x.x << n, x.y << n, x.z << n); }

        /// <summary>Returns the result of a componentwise right shift operation on an byte3 vector by a number of bits specified by a single int.</summary>
        /// <param name="x">The vector to right shift.</param>
        /// <param name="n">The number of bits to right shift.</param>
        /// <returns>The result of the componentwise right shift.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 operator >>(byte3 x, int n) { return new byte3(x.x >> n, x.y >> n, x.z >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (byte3 lhs, byte3 rhs) { return new bool3 (lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z); }

        /// <summary>Returns the result of a componentwise equality operation on a byte3 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (byte3 lhs, byte rhs) { return new bool3 (lhs.x == rhs, lhs.y == rhs, lhs.z == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a byte value and a byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise equality.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise equality.</param>
        /// <returns>bool3 result of the componentwise equality.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator == (byte lhs, byte3 rhs) { return new bool3 (lhs == rhs.x, lhs == rhs.y, lhs == rhs.z); }


        /// <summary>Returns the result of a componentwise not equal operation on two byte3 vectors.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (byte3 lhs, byte3 rhs) { return new bool3 (lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z); }

        /// <summary>Returns the result of a componentwise not equal operation on a byte3 vector and a byte value.</summary>
        /// <param name="lhs">Left hand side byte3 to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (byte3 lhs, byte rhs) { return new bool3 (lhs.x != rhs, lhs.y != rhs, lhs.z != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a byte value and a byte3 vector.</summary>
        /// <param name="lhs">Left hand side byte to use to compute componentwise not equal.</param>
        /// <param name="rhs">Right hand side byte3 to use to compute componentwise not equal.</param>
        /// <returns>bool3 result of the componentwise not equal.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool3 operator != (byte lhs, byte3 rhs) { return new bool3 (lhs != rhs.x, lhs != rhs.y, lhs != rhs.z); }




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
        public byte4 xxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, x, z); }
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
        public byte4 xxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, x, z, z); }
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
        public byte4 xyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, x, z); }
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
        public byte4 xyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 xzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(x, z, z, z); }
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
        public byte4 yxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, x, z); }
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
        public byte4 yxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, x, z, z); }
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
        public byte4 yyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, x, z); }
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
        public byte4 yyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 yzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(y, z, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zxzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, x, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zyzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, x, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, y, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte4 zzzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte4(z, z, z, z); }
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
        public byte3 xxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, x, z); }
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
        public byte3 xyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; z = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 xzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 xzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 xzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(x, z, z); }
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
        public byte3 yxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; z = value.z; }
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
        public byte3 yyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 yzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 yzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 yzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(y, z, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, x, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; y = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zxz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, x, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; x = value.z; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, y, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zyz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, y, z); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zzx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, z, x); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zzy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, z, y); }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte3 zzz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte3(z, z, z); }
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
        public byte2 xz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(x, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; z = value.y; }
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


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte2 yz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(y, z); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; z = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte2 zx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(z, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; x = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte2 zy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(z, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { z = value.x; y = value.y; }
        }


        /// <summary>Swizzles the vector.</summary>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte2 zz
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new byte2(z, z); }
        }



        /// <summary>Returns the byte element at a specified index.</summary>
        unsafe public byte this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (byte3* array = &this) { return ((byte*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 3)
                    throw new System.ArgumentException("index must be between[0...2]");
#endif
                fixed (byte* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the byte3 is equal to a given byte3, false otherwise.</summary>
        /// <param name="rhs">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(byte3 rhs) { return x == rhs.x && y == rhs.y && z == rhs.z; }

        /// <summary>Returns true if the byte3 is equal to a given byte3, false otherwise.</summary>
        /// <param name="o">Right hand side argument to compare equality with.</param>
        /// <returns>The result of the equality comparison.</returns>
        public override bool Equals(object o) { return o is byte3 converted && Equals(converted); }


        /// <summary>Returns a hash code for the byte3.</summary>
        /// <returns>The computed hash code.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)mathExtended.hash(this); }


        /// <summary>Returns a string representation of the byte3.</summary>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("byte3({0}, {1}, {2})", x, y, z);
        }

        /// <summary>Returns a string representation of the byte3 using a specified format and culture-specific format information.</summary>
        /// <param name="format">Format string to use during string formatting.</param>
        /// <param name="formatProvider">Format provider to use during string formatting.</param>
        /// <returns>String representation of the value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("byte3({0}, {1}, {2})", x.ToString(format, formatProvider), y.ToString(format, formatProvider), z.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public byte x;
            public byte y;
            public byte z;
            public DebuggerProxy(byte3 v)
            {
                x = v.x;
                y = v.y;
                z = v.z;
            }
        }

    }

    public static partial class mathExtended
    {
        /// <summary>Returns a byte3 vector constructed from three byte values.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="y">The constructed vector's y component will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>byte3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(byte x, byte y, byte z) { return new byte3(x, y, z); }

        /// <summary>Returns a byte3 vector constructed from a byte value and a byte2 vector.</summary>
        /// <param name="x">The constructed vector's x component will be set to this value.</param>
        /// <param name="yz">The constructed vector's yz components will be set to this value.</param>
        /// <returns>byte3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(byte x, byte2 yz) { return new byte3(x, yz); }

        /// <summary>Returns a byte3 vector constructed from a byte2 vector and a byte value.</summary>
        /// <param name="xy">The constructed vector's xy components will be set to this value.</param>
        /// <param name="z">The constructed vector's z component will be set to this value.</param>
        /// <returns>byte3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(byte2 xy, byte z) { return new byte3(xy, z); }

        /// <summary>Returns a byte3 vector constructed from a byte3 vector.</summary>
        /// <param name="xyz">The constructed vector's xyz components will be set to this value.</param>
        /// <returns>byte3 constructed from arguments.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(byte3 xyz) { return new byte3(xyz); }

        /// <summary>Returns a byte3 vector constructed from a single byte value by assigning it to every component.</summary>
        /// <param name="v">byte to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(byte v) { return new byte3(v); }

        /// <summary>Returns a byte3 vector constructed from a single float value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">float to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(float v) { return new byte3(v); }

        /// <summary>Return a byte3 vector constructed from a float3 vector by componentwise conversion.</summary>
        /// <param name="v">float3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(float3 v) { return new byte3(v); }

        /// <summary>Returns a byte3 vector constructed from a single double value by converting it to byte and assigning it to every component.</summary>
        /// <param name="v">double to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(double v) { return new byte3(v); }

        /// <summary>Return a byte3 vector constructed from a double3 vector by componentwise conversion.</summary>
        /// <param name="v">double3 to convert to byte3</param>
        /// <returns>Converted value.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static byte3 byte3(double3 v) { return new byte3(v); }

        /// <summary>Returns a uint hash code of a byte3 vector.</summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(byte3 v)
        {
            return Mathematics.math.csum(new uint3((uint)v.x, (uint)v.y, (uint)v.z) * new uint3(0x685835CFu, 0xC3D32AE1u, 0xB966942Fu)) + 0xFE9856B3u;
        }

        /// <summary>
        /// Returns a uint3 vector hash code of a byte3 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        /// <param name="v">Vector value to hash.</param>
        /// <returns>uint3 hash of the argument.</returns>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 hashwide(byte3 v)
        {
            return (new uint3((uint)v.x, (uint)v.y, (uint)v.z) * new uint3(0xFA3A3285u, 0xAD55999Du, 0xDCDD5341u)) + 0x94DDD769u;
        }

    }
}
