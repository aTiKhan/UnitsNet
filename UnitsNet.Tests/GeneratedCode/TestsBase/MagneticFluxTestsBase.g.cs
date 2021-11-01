//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using UnitsNet.Tests.TestsBase;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of MagneticFlux.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class MagneticFluxTestsBase : QuantityTestsBase
    {
        protected abstract double WebersInOneWeber { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double WebersTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MagneticFlux((double)0.0, MagneticFluxUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new MagneticFlux();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(MagneticFluxUnit.Weber, quantity.Unit);
        }


        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MagneticFlux(double.PositiveInfinity, MagneticFluxUnit.Weber));
            Assert.Throws<ArgumentException>(() => new MagneticFlux(double.NegativeInfinity, MagneticFluxUnit.Weber));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new MagneticFlux(double.NaN, MagneticFluxUnit.Weber));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new MagneticFlux(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new MagneticFlux(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (MagneticFlux) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void MagneticFlux_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new MagneticFlux(1, MagneticFluxUnit.Weber);

            QuantityInfo<MagneticFluxUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(MagneticFlux.Zero, quantityInfo.Zero);
            Assert.Equal("MagneticFlux", quantityInfo.Name);
            Assert.Equal(QuantityType.MagneticFlux, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<MagneticFluxUnit>().Except(new[] {MagneticFluxUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void WeberToMagneticFluxUnits()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            AssertEx.EqualTolerance(WebersInOneWeber, weber.Webers, WebersTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = MagneticFlux.From(1, MagneticFluxUnit.Weber);
            AssertEx.EqualTolerance(1, quantity00.Webers, WebersTolerance);
            Assert.Equal(MagneticFluxUnit.Weber, quantity00.Unit);

        }

        [Fact]
        public void FromWebers_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MagneticFlux.FromWebers(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => MagneticFlux.FromWebers(double.NegativeInfinity));
        }

        [Fact]
        public void FromWebers_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => MagneticFlux.FromWebers(double.NaN));
        }

        [Fact]
        public void As()
        {
            var weber = MagneticFlux.FromWebers(1);
            AssertEx.EqualTolerance(WebersInOneWeber, weber.As(MagneticFluxUnit.Weber), WebersTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new MagneticFlux(value: 1, unit: MagneticFlux.ConversionBaseUnit);
            Func<object> AsWithSIUnitSystem = () => quantity.As(UnitSystem.SI);

            if (SupportsSIUnitSystem)
            {
                var value = (double) AsWithSIUnitSystem();
                Assert.Equal(1, value);
            }
            else
            {
                Assert.Throws<ArgumentException>(AsWithSIUnitSystem);
            }
        }

        [Fact]
        public void ToUnit()
        {
            var weber = MagneticFlux.FromWebers(1);

            var weberQuantity = weber.ToUnit(MagneticFluxUnit.Weber);
            AssertEx.EqualTolerance(WebersInOneWeber, (double)weberQuantity.Value, WebersTolerance);
            Assert.Equal(MagneticFluxUnit.Weber, weberQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = MagneticFlux.FromWebers(1).ToBaseUnit();
            Assert.Equal(MagneticFlux.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            AssertEx.EqualTolerance(1, MagneticFlux.FromWebers(weber.Webers).Webers, WebersTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            MagneticFlux v = MagneticFlux.FromWebers(1);
            AssertEx.EqualTolerance(-1, -v.Webers, WebersTolerance);
            AssertEx.EqualTolerance(2, (MagneticFlux.FromWebers(3)-v).Webers, WebersTolerance);
            AssertEx.EqualTolerance(2, (v + v).Webers, WebersTolerance);
            AssertEx.EqualTolerance(10, (v*10).Webers, WebersTolerance);
            AssertEx.EqualTolerance(10, (10*v).Webers, WebersTolerance);
            AssertEx.EqualTolerance(2, (MagneticFlux.FromWebers(10)/5).Webers, WebersTolerance);
            AssertEx.EqualTolerance(2, MagneticFlux.FromWebers(10)/MagneticFlux.FromWebers(5), WebersTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            MagneticFlux oneWeber = MagneticFlux.FromWebers(1);
            MagneticFlux twoWebers = MagneticFlux.FromWebers(2);

            Assert.True(oneWeber < twoWebers);
            Assert.True(oneWeber <= twoWebers);
            Assert.True(twoWebers > oneWeber);
            Assert.True(twoWebers >= oneWeber);

            Assert.False(oneWeber > twoWebers);
            Assert.False(oneWeber >= twoWebers);
            Assert.False(twoWebers < oneWeber);
            Assert.False(twoWebers <= oneWeber);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.Equal(0, weber.CompareTo(weber));
            Assert.True(weber.CompareTo(MagneticFlux.Zero) > 0);
            Assert.True(MagneticFlux.Zero.CompareTo(weber) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.Throws<ArgumentException>(() => weber.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.Throws<ArgumentNullException>(() => weber.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = MagneticFlux.FromWebers(1);
            var b = MagneticFlux.FromWebers(2);

#pragma warning disable CS8073
// ReSharper disable EqualExpressionComparison

            Assert.True(a == a);
            Assert.False(a != a);

            Assert.True(a != b);
            Assert.False(a == b);

            Assert.False(a == null);
            Assert.False(null == a);

// ReSharper restore EqualExpressionComparison
#pragma warning restore CS8073
        }

        [Fact]
        public void Equals_SameType_IsImplemented()
        {
            var a = MagneticFlux.FromWebers(1);
            var b = MagneticFlux.FromWebers(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = MagneticFlux.FromWebers(1);
            object b = MagneticFlux.FromWebers(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = MagneticFlux.FromWebers(1);
            Assert.True(v.Equals(MagneticFlux.FromWebers(1), WebersTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(MagneticFlux.Zero, WebersTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = MagneticFlux.FromWebers(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(MagneticFlux.FromWebers(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.False(weber.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            MagneticFlux weber = MagneticFlux.FromWebers(1);
            Assert.False(weber.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(MagneticFluxUnit.Undefined, MagneticFlux.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(MagneticFluxUnit)).Cast<MagneticFluxUnit>();
            foreach(var unit in units)
            {
                if(unit == MagneticFluxUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(MagneticFlux.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 Wb", new MagneticFlux(1, MagneticFluxUnit.Weber).ToString());
            }
            finally
            {
                Thread.CurrentThread.CurrentUICulture = prevCulture;
            }
        }

        [Fact]
        public void ToString_WithSwedishCulture_ReturnsUnitAbbreviationForEnglishCultureSinceThereAreNoMappings()
        {
            // Chose this culture, because we don't currently have any abbreviations mapped for that culture and we expect the en-US to be used as fallback.
            var swedishCulture = CultureInfo.GetCultureInfo("sv-SE");

            Assert.Equal("1 Wb", new MagneticFlux(1, MagneticFluxUnit.Weber).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s1"));
                Assert.Equal("0.12 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s2"));
                Assert.Equal("0.123 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s3"));
                Assert.Equal("0.1235 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s4"));
            }
            finally
            {
                CultureInfo.CurrentUICulture = oldCulture;
            }
        }

        [Fact]
        public void ToString_SFormatAndCulture_FormatsNumberWithGivenDigitsAfterRadixForGivenCulture()
        {
            var culture = CultureInfo.InvariantCulture;
            Assert.Equal("0.1 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s1", culture));
            Assert.Equal("0.12 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s2", culture));
            Assert.Equal("0.123 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s3", culture));
            Assert.Equal("0.1235 Wb", new MagneticFlux(0.123456, MagneticFluxUnit.Weber).ToString("s4", culture));
        }


        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }


        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(MagneticFlux)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(MagneticFluxUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(QuantityType.MagneticFlux, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(MagneticFlux.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(MagneticFlux.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = MagneticFlux.FromWebers(1.0);
            Assert.Equal(new {MagneticFlux.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = MagneticFlux.FromWebers(value);
            Assert.Equal(MagneticFlux.FromWebers(-value), -quantity);
        }
    }
}
