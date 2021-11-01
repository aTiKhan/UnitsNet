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
    /// Test of KinematicViscosity.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class KinematicViscosityTestsBase : QuantityTestsBase
    {
        protected abstract double CentistokesInOneSquareMeterPerSecond { get; }
        protected abstract double DecistokesInOneSquareMeterPerSecond { get; }
        protected abstract double KilostokesInOneSquareMeterPerSecond { get; }
        protected abstract double MicrostokesInOneSquareMeterPerSecond { get; }
        protected abstract double MillistokesInOneSquareMeterPerSecond { get; }
        protected abstract double NanostokesInOneSquareMeterPerSecond { get; }
        protected abstract double SquareFeetPerSecondInOneSquareMeterPerSecond { get; }
        protected abstract double SquareMetersPerSecondInOneSquareMeterPerSecond { get; }
        protected abstract double StokesInOneSquareMeterPerSecond { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CentistokesTolerance { get { return 1e-5; } }
        protected virtual double DecistokesTolerance { get { return 1e-5; } }
        protected virtual double KilostokesTolerance { get { return 1e-5; } }
        protected virtual double MicrostokesTolerance { get { return 1e-5; } }
        protected virtual double MillistokesTolerance { get { return 1e-5; } }
        protected virtual double NanostokesTolerance { get { return 1e-5; } }
        protected virtual double SquareFeetPerSecondTolerance { get { return 1e-5; } }
        protected virtual double SquareMetersPerSecondTolerance { get { return 1e-5; } }
        protected virtual double StokesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void Ctor_WithUndefinedUnit_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new KinematicViscosity((double)0.0, KinematicViscosityUnit.Undefined));
        }

        [Fact]
        public void DefaultCtor_ReturnsQuantityWithZeroValueAndBaseUnit()
        {
            var quantity = new KinematicViscosity();
            Assert.Equal(0, quantity.Value);
            Assert.Equal(KinematicViscosityUnit.SquareMeterPerSecond, quantity.Unit);
        }

        [Fact]
        public void Ctor_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new KinematicViscosity(double.PositiveInfinity, KinematicViscosityUnit.SquareMeterPerSecond));
            Assert.Throws<ArgumentException>(() => new KinematicViscosity(double.NegativeInfinity, KinematicViscosityUnit.SquareMeterPerSecond));
        }

        [Fact]
        public void Ctor_WithNaNValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new KinematicViscosity(double.NaN, KinematicViscosityUnit.SquareMeterPerSecond));
        }

        [Fact]
        public void Ctor_NullAsUnitSystem_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => new KinematicViscosity(value: 1, unitSystem: null));
        }

        [Fact]
        public void Ctor_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            Func<object> TestCode = () => new KinematicViscosity(value: 1, unitSystem: UnitSystem.SI);
            if (SupportsSIUnitSystem)
            {
                var quantity = (KinematicViscosity) TestCode();
                Assert.Equal(1, quantity.Value);
            }
            else
            {
                Assert.Throws<ArgumentException>(TestCode);
            }
        }

        [Fact]
        public void KinematicViscosity_QuantityInfo_ReturnsQuantityInfoDescribingQuantity()
        {
            var quantity = new KinematicViscosity(1, KinematicViscosityUnit.SquareMeterPerSecond);

            QuantityInfo<KinematicViscosityUnit> quantityInfo = quantity.QuantityInfo;

            Assert.Equal(KinematicViscosity.Zero, quantityInfo.Zero);
            Assert.Equal("KinematicViscosity", quantityInfo.Name);
            Assert.Equal(QuantityType.KinematicViscosity, quantityInfo.QuantityType);

            var units = EnumUtils.GetEnumValues<KinematicViscosityUnit>().Except(new[] {KinematicViscosityUnit.Undefined}).ToArray();
            var unitNames = units.Select(x => x.ToString());

            // Obsolete members
            Assert.Equal(units, quantityInfo.Units);
            Assert.Equal(unitNames, quantityInfo.UnitNames);
        }

        [Fact]
        public void SquareMeterPerSecondToKinematicViscosityUnits()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            AssertEx.EqualTolerance(CentistokesInOneSquareMeterPerSecond, squaremeterpersecond.Centistokes, CentistokesTolerance);
            AssertEx.EqualTolerance(DecistokesInOneSquareMeterPerSecond, squaremeterpersecond.Decistokes, DecistokesTolerance);
            AssertEx.EqualTolerance(KilostokesInOneSquareMeterPerSecond, squaremeterpersecond.Kilostokes, KilostokesTolerance);
            AssertEx.EqualTolerance(MicrostokesInOneSquareMeterPerSecond, squaremeterpersecond.Microstokes, MicrostokesTolerance);
            AssertEx.EqualTolerance(MillistokesInOneSquareMeterPerSecond, squaremeterpersecond.Millistokes, MillistokesTolerance);
            AssertEx.EqualTolerance(NanostokesInOneSquareMeterPerSecond, squaremeterpersecond.Nanostokes, NanostokesTolerance);
            AssertEx.EqualTolerance(SquareFeetPerSecondInOneSquareMeterPerSecond, squaremeterpersecond.SquareFeetPerSecond, SquareFeetPerSecondTolerance);
            AssertEx.EqualTolerance(SquareMetersPerSecondInOneSquareMeterPerSecond, squaremeterpersecond.SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(StokesInOneSquareMeterPerSecond, squaremeterpersecond.Stokes, StokesTolerance);
        }

        [Fact]
        public void From_ValueAndUnit_ReturnsQuantityWithSameValueAndUnit()
        {
            var quantity00 = KinematicViscosity.From(1, KinematicViscosityUnit.Centistokes);
            AssertEx.EqualTolerance(1, quantity00.Centistokes, CentistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Centistokes, quantity00.Unit);

            var quantity01 = KinematicViscosity.From(1, KinematicViscosityUnit.Decistokes);
            AssertEx.EqualTolerance(1, quantity01.Decistokes, DecistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Decistokes, quantity01.Unit);

            var quantity02 = KinematicViscosity.From(1, KinematicViscosityUnit.Kilostokes);
            AssertEx.EqualTolerance(1, quantity02.Kilostokes, KilostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Kilostokes, quantity02.Unit);

            var quantity03 = KinematicViscosity.From(1, KinematicViscosityUnit.Microstokes);
            AssertEx.EqualTolerance(1, quantity03.Microstokes, MicrostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Microstokes, quantity03.Unit);

            var quantity04 = KinematicViscosity.From(1, KinematicViscosityUnit.Millistokes);
            AssertEx.EqualTolerance(1, quantity04.Millistokes, MillistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Millistokes, quantity04.Unit);

            var quantity05 = KinematicViscosity.From(1, KinematicViscosityUnit.Nanostokes);
            AssertEx.EqualTolerance(1, quantity05.Nanostokes, NanostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Nanostokes, quantity05.Unit);

            var quantity06 = KinematicViscosity.From(1, KinematicViscosityUnit.SquareFootPerSecond);
            AssertEx.EqualTolerance(1, quantity06.SquareFeetPerSecond, SquareFeetPerSecondTolerance);
            Assert.Equal(KinematicViscosityUnit.SquareFootPerSecond, quantity06.Unit);

            var quantity07 = KinematicViscosity.From(1, KinematicViscosityUnit.SquareMeterPerSecond);
            AssertEx.EqualTolerance(1, quantity07.SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            Assert.Equal(KinematicViscosityUnit.SquareMeterPerSecond, quantity07.Unit);

            var quantity08 = KinematicViscosity.From(1, KinematicViscosityUnit.Stokes);
            AssertEx.EqualTolerance(1, quantity08.Stokes, StokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Stokes, quantity08.Unit);

        }

        [Fact]
        public void FromSquareMetersPerSecond_WithInfinityValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => KinematicViscosity.FromSquareMetersPerSecond(double.PositiveInfinity));
            Assert.Throws<ArgumentException>(() => KinematicViscosity.FromSquareMetersPerSecond(double.NegativeInfinity));
        }

        [Fact]
        public void FromSquareMetersPerSecond_WithNanValue_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => KinematicViscosity.FromSquareMetersPerSecond(double.NaN));
        }

        [Fact]
        public void As()
        {
            var squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            AssertEx.EqualTolerance(CentistokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Centistokes), CentistokesTolerance);
            AssertEx.EqualTolerance(DecistokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Decistokes), DecistokesTolerance);
            AssertEx.EqualTolerance(KilostokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Kilostokes), KilostokesTolerance);
            AssertEx.EqualTolerance(MicrostokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Microstokes), MicrostokesTolerance);
            AssertEx.EqualTolerance(MillistokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Millistokes), MillistokesTolerance);
            AssertEx.EqualTolerance(NanostokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Nanostokes), NanostokesTolerance);
            AssertEx.EqualTolerance(SquareFeetPerSecondInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.SquareFootPerSecond), SquareFeetPerSecondTolerance);
            AssertEx.EqualTolerance(SquareMetersPerSecondInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.SquareMeterPerSecond), SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(StokesInOneSquareMeterPerSecond, squaremeterpersecond.As(KinematicViscosityUnit.Stokes), StokesTolerance);
        }

        [Fact]
        public void As_SIUnitSystem_ThrowsArgumentExceptionIfNotSupported()
        {
            var quantity = new KinematicViscosity(value: 1, unit: KinematicViscosity.ConversionBaseUnit);
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
            var squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);

            var centistokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Centistokes);
            AssertEx.EqualTolerance(CentistokesInOneSquareMeterPerSecond, (double)centistokesQuantity.Value, CentistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Centistokes, centistokesQuantity.Unit);

            var decistokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Decistokes);
            AssertEx.EqualTolerance(DecistokesInOneSquareMeterPerSecond, (double)decistokesQuantity.Value, DecistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Decistokes, decistokesQuantity.Unit);

            var kilostokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Kilostokes);
            AssertEx.EqualTolerance(KilostokesInOneSquareMeterPerSecond, (double)kilostokesQuantity.Value, KilostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Kilostokes, kilostokesQuantity.Unit);

            var microstokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Microstokes);
            AssertEx.EqualTolerance(MicrostokesInOneSquareMeterPerSecond, (double)microstokesQuantity.Value, MicrostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Microstokes, microstokesQuantity.Unit);

            var millistokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Millistokes);
            AssertEx.EqualTolerance(MillistokesInOneSquareMeterPerSecond, (double)millistokesQuantity.Value, MillistokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Millistokes, millistokesQuantity.Unit);

            var nanostokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Nanostokes);
            AssertEx.EqualTolerance(NanostokesInOneSquareMeterPerSecond, (double)nanostokesQuantity.Value, NanostokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Nanostokes, nanostokesQuantity.Unit);

            var squarefootpersecondQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.SquareFootPerSecond);
            AssertEx.EqualTolerance(SquareFeetPerSecondInOneSquareMeterPerSecond, (double)squarefootpersecondQuantity.Value, SquareFeetPerSecondTolerance);
            Assert.Equal(KinematicViscosityUnit.SquareFootPerSecond, squarefootpersecondQuantity.Unit);

            var squaremeterpersecondQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.SquareMeterPerSecond);
            AssertEx.EqualTolerance(SquareMetersPerSecondInOneSquareMeterPerSecond, (double)squaremeterpersecondQuantity.Value, SquareMetersPerSecondTolerance);
            Assert.Equal(KinematicViscosityUnit.SquareMeterPerSecond, squaremeterpersecondQuantity.Unit);

            var stokesQuantity = squaremeterpersecond.ToUnit(KinematicViscosityUnit.Stokes);
            AssertEx.EqualTolerance(StokesInOneSquareMeterPerSecond, (double)stokesQuantity.Value, StokesTolerance);
            Assert.Equal(KinematicViscosityUnit.Stokes, stokesQuantity.Unit);
        }

        [Fact]
        public void ToBaseUnit_ReturnsQuantityWithBaseUnit()
        {
            var quantityInBaseUnit = KinematicViscosity.FromSquareMetersPerSecond(1).ToBaseUnit();
            Assert.Equal(KinematicViscosity.ConversionBaseUnit, quantityInBaseUnit.Unit);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromCentistokes(squaremeterpersecond.Centistokes).SquareMetersPerSecond, CentistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromDecistokes(squaremeterpersecond.Decistokes).SquareMetersPerSecond, DecistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromKilostokes(squaremeterpersecond.Kilostokes).SquareMetersPerSecond, KilostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromMicrostokes(squaremeterpersecond.Microstokes).SquareMetersPerSecond, MicrostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromMillistokes(squaremeterpersecond.Millistokes).SquareMetersPerSecond, MillistokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromNanostokes(squaremeterpersecond.Nanostokes).SquareMetersPerSecond, NanostokesTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromSquareFeetPerSecond(squaremeterpersecond.SquareFeetPerSecond).SquareMetersPerSecond, SquareFeetPerSecondTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromSquareMetersPerSecond(squaremeterpersecond.SquareMetersPerSecond).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(1, KinematicViscosity.FromStokes(squaremeterpersecond.Stokes).SquareMetersPerSecond, StokesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            KinematicViscosity v = KinematicViscosity.FromSquareMetersPerSecond(1);
            AssertEx.EqualTolerance(-1, -v.SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (KinematicViscosity.FromSquareMetersPerSecond(3)-v).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (v + v).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (v*10).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(10, (10*v).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, (KinematicViscosity.FromSquareMetersPerSecond(10)/5).SquareMetersPerSecond, SquareMetersPerSecondTolerance);
            AssertEx.EqualTolerance(2, KinematicViscosity.FromSquareMetersPerSecond(10)/KinematicViscosity.FromSquareMetersPerSecond(5), SquareMetersPerSecondTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            KinematicViscosity oneSquareMeterPerSecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            KinematicViscosity twoSquareMetersPerSecond = KinematicViscosity.FromSquareMetersPerSecond(2);

            Assert.True(oneSquareMeterPerSecond < twoSquareMetersPerSecond);
            Assert.True(oneSquareMeterPerSecond <= twoSquareMetersPerSecond);
            Assert.True(twoSquareMetersPerSecond > oneSquareMeterPerSecond);
            Assert.True(twoSquareMetersPerSecond >= oneSquareMeterPerSecond);

            Assert.False(oneSquareMeterPerSecond > twoSquareMetersPerSecond);
            Assert.False(oneSquareMeterPerSecond >= twoSquareMetersPerSecond);
            Assert.False(twoSquareMetersPerSecond < oneSquareMeterPerSecond);
            Assert.False(twoSquareMetersPerSecond <= oneSquareMeterPerSecond);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.Equal(0, squaremeterpersecond.CompareTo(squaremeterpersecond));
            Assert.True(squaremeterpersecond.CompareTo(KinematicViscosity.Zero) > 0);
            Assert.True(KinematicViscosity.Zero.CompareTo(squaremeterpersecond) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.Throws<ArgumentException>(() => squaremeterpersecond.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.Throws<ArgumentNullException>(() => squaremeterpersecond.CompareTo(null));
        }

        [Fact]
        public void EqualityOperators()
        {
            var a = KinematicViscosity.FromSquareMetersPerSecond(1);
            var b = KinematicViscosity.FromSquareMetersPerSecond(2);

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
            var a = KinematicViscosity.FromSquareMetersPerSecond(1);
            var b = KinematicViscosity.FromSquareMetersPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
        }

        [Fact]
        public void Equals_QuantityAsObject_IsImplemented()
        {
            object a = KinematicViscosity.FromSquareMetersPerSecond(1);
            object b = KinematicViscosity.FromSquareMetersPerSecond(2);

            Assert.True(a.Equals(a));
            Assert.False(a.Equals(b));
            Assert.False(a.Equals((object)null));
        }

        [Fact]
        public void Equals_RelativeTolerance_IsImplemented()
        {
            var v = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.True(v.Equals(KinematicViscosity.FromSquareMetersPerSecond(1), SquareMetersPerSecondTolerance, ComparisonType.Relative));
            Assert.False(v.Equals(KinematicViscosity.Zero, SquareMetersPerSecondTolerance, ComparisonType.Relative));
        }

        [Fact]
        public void Equals_NegativeRelativeTolerance_ThrowsArgumentOutOfRangeException()
        {
            var v = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.Throws<ArgumentOutOfRangeException>(() => v.Equals(KinematicViscosity.FromSquareMetersPerSecond(1), -1, ComparisonType.Relative));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.False(squaremeterpersecond.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            KinematicViscosity squaremeterpersecond = KinematicViscosity.FromSquareMetersPerSecond(1);
            Assert.False(squaremeterpersecond.Equals(null));
        }

        [Fact]
        public void UnitsDoesNotContainUndefined()
        {
            Assert.DoesNotContain(KinematicViscosityUnit.Undefined, KinematicViscosity.Units);
        }

        [Fact]
        public void HasAtLeastOneAbbreviationSpecified()
        {
            var units = Enum.GetValues(typeof(KinematicViscosityUnit)).Cast<KinematicViscosityUnit>();
            foreach(var unit in units)
            {
                if(unit == KinematicViscosityUnit.Undefined)
                    continue;

                var defaultAbbreviation = UnitAbbreviationsCache.Default.GetDefaultAbbreviation(unit);
            }
        }

        [Fact]
        public void BaseDimensionsShouldNeverBeNull()
        {
            Assert.False(KinematicViscosity.BaseDimensions is null);
        }

        [Fact]
        public void ToString_ReturnsValueAndUnitAbbreviationInCurrentCulture()
        {
            var prevCulture = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US");
            try {
                Assert.Equal("1 cSt", new KinematicViscosity(1, KinematicViscosityUnit.Centistokes).ToString());
                Assert.Equal("1 dSt", new KinematicViscosity(1, KinematicViscosityUnit.Decistokes).ToString());
                Assert.Equal("1 kSt", new KinematicViscosity(1, KinematicViscosityUnit.Kilostokes).ToString());
                Assert.Equal("1 µSt", new KinematicViscosity(1, KinematicViscosityUnit.Microstokes).ToString());
                Assert.Equal("1 mSt", new KinematicViscosity(1, KinematicViscosityUnit.Millistokes).ToString());
                Assert.Equal("1 nSt", new KinematicViscosity(1, KinematicViscosityUnit.Nanostokes).ToString());
                Assert.Equal("1 ft²/s", new KinematicViscosity(1, KinematicViscosityUnit.SquareFootPerSecond).ToString());
                Assert.Equal("1 m²/s", new KinematicViscosity(1, KinematicViscosityUnit.SquareMeterPerSecond).ToString());
                Assert.Equal("1 St", new KinematicViscosity(1, KinematicViscosityUnit.Stokes).ToString());
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

            Assert.Equal("1 cSt", new KinematicViscosity(1, KinematicViscosityUnit.Centistokes).ToString(swedishCulture));
            Assert.Equal("1 dSt", new KinematicViscosity(1, KinematicViscosityUnit.Decistokes).ToString(swedishCulture));
            Assert.Equal("1 kSt", new KinematicViscosity(1, KinematicViscosityUnit.Kilostokes).ToString(swedishCulture));
            Assert.Equal("1 µSt", new KinematicViscosity(1, KinematicViscosityUnit.Microstokes).ToString(swedishCulture));
            Assert.Equal("1 mSt", new KinematicViscosity(1, KinematicViscosityUnit.Millistokes).ToString(swedishCulture));
            Assert.Equal("1 nSt", new KinematicViscosity(1, KinematicViscosityUnit.Nanostokes).ToString(swedishCulture));
            Assert.Equal("1 ft²/s", new KinematicViscosity(1, KinematicViscosityUnit.SquareFootPerSecond).ToString(swedishCulture));
            Assert.Equal("1 m²/s", new KinematicViscosity(1, KinematicViscosityUnit.SquareMeterPerSecond).ToString(swedishCulture));
            Assert.Equal("1 St", new KinematicViscosity(1, KinematicViscosityUnit.Stokes).ToString(swedishCulture));
        }

        [Fact]
        public void ToString_SFormat_FormatsNumberWithGivenDigitsAfterRadixForCurrentCulture()
        {
            var oldCulture = CultureInfo.CurrentUICulture;
            try
            {
                CultureInfo.CurrentUICulture = CultureInfo.InvariantCulture;
                Assert.Equal("0.1 m²/s", new KinematicViscosity(0.123456, KinematicViscosityUnit.SquareMeterPerSecond).ToString("s1"));
                Assert.Equal("0.12 m²/s", new KinematicViscosity(0.123456, KinematicViscosityUnit.SquareMeterPerSecond).ToString("s2"));
                Assert.Equal("0.123 m²/s", new KinematicViscosity(0.123456, KinematicViscosityUnit.SquareMeterPerSecond).ToString("s3"));
                Assert.Equal("0.1235 m²/s", new KinematicViscosity(0.123456, KinematicViscosityUnit.SquareMeterPerSecond).ToString("s4"));
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
            Assert.Equal("0.1 m²/s", new KinematicViscosity(0.123456, KinematicViscosityUnit.SquareMeterPerSecond).ToString("s1", culture));
            Assert.Equal("0.12 m²/s", new KinematicViscosity(0.123456, KinematicViscosityUnit.SquareMeterPerSecond).ToString("s2", culture));
            Assert.Equal("0.123 m²/s", new KinematicViscosity(0.123456, KinematicViscosityUnit.SquareMeterPerSecond).ToString("s3", culture));
            Assert.Equal("0.1235 m²/s", new KinematicViscosity(0.123456, KinematicViscosityUnit.SquareMeterPerSecond).ToString("s4", culture));
        }

        [Fact]
        public void ToString_NullFormat_ThrowsArgumentNullException()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, null, null));
        }

        [Fact]
        public void ToString_NullArgs_ThrowsArgumentNullException()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Throws<ArgumentNullException>(() => quantity.ToString(null, "g", null));
        }

        [Fact]
        public void ToString_NullProvider_EqualsCurrentUICulture()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal(quantity.ToString(CultureInfo.CurrentUICulture, "g"), quantity.ToString(null, "g"));
        }

        [Fact]
        public void Convert_ToBool_ThrowsInvalidCastException()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToBoolean(quantity));
        }

        [Fact]
        public void Convert_ToByte_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
           Assert.Equal((byte)quantity.Value, Convert.ToByte(quantity));
        }

        [Fact]
        public void Convert_ToChar_ThrowsInvalidCastException()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToChar(quantity));
        }

        [Fact]
        public void Convert_ToDateTime_ThrowsInvalidCastException()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ToDateTime(quantity));
        }

        [Fact]
        public void Convert_ToDecimal_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((decimal)quantity.Value, Convert.ToDecimal(quantity));
        }

        [Fact]
        public void Convert_ToDouble_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((double)quantity.Value, Convert.ToDouble(quantity));
        }

        [Fact]
        public void Convert_ToInt16_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((short)quantity.Value, Convert.ToInt16(quantity));
        }

        [Fact]
        public void Convert_ToInt32_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((int)quantity.Value, Convert.ToInt32(quantity));
        }

        [Fact]
        public void Convert_ToInt64_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((long)quantity.Value, Convert.ToInt64(quantity));
        }

        [Fact]
        public void Convert_ToSByte_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((sbyte)quantity.Value, Convert.ToSByte(quantity));
        }

        [Fact]
        public void Convert_ToSingle_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((float)quantity.Value, Convert.ToSingle(quantity));
        }

        [Fact]
        public void Convert_ToString_EqualsToString()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal(quantity.ToString(), Convert.ToString(quantity));
        }

        [Fact]
        public void Convert_ToUInt16_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((ushort)quantity.Value, Convert.ToUInt16(quantity));
        }

        [Fact]
        public void Convert_ToUInt32_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((uint)quantity.Value, Convert.ToUInt32(quantity));
        }

        [Fact]
        public void Convert_ToUInt64_EqualsValueAsSameType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal((ulong)quantity.Value, Convert.ToUInt64(quantity));
        }

        [Fact]
        public void Convert_ChangeType_SelfType_EqualsSelf()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal(quantity, Convert.ChangeType(quantity, typeof(KinematicViscosity)));
        }

        [Fact]
        public void Convert_ChangeType_UnitType_EqualsUnit()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal(quantity.Unit, Convert.ChangeType(quantity, typeof(KinematicViscosityUnit)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityType_EqualsQuantityType()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal(QuantityType.KinematicViscosity, Convert.ChangeType(quantity, typeof(QuantityType)));
        }

        [Fact]
        public void Convert_ChangeType_QuantityInfo_EqualsQuantityInfo()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal(KinematicViscosity.Info, Convert.ChangeType(quantity, typeof(QuantityInfo)));
        }

        [Fact]
        public void Convert_ChangeType_BaseDimensions_EqualsBaseDimensions()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal(KinematicViscosity.BaseDimensions, Convert.ChangeType(quantity, typeof(BaseDimensions)));
        }

        [Fact]
        public void Convert_ChangeType_InvalidType_ThrowsInvalidCastException()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Throws<InvalidCastException>(() => Convert.ChangeType(quantity, typeof(QuantityFormatter)));
        }

        [Fact]
        public void GetHashCode_Equals()
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(1.0);
            Assert.Equal(new {KinematicViscosity.Info.Name, quantity.Value, quantity.Unit}.GetHashCode(), quantity.GetHashCode());
        }

        [Theory]
        [InlineData(1.0)]
        [InlineData(-1.0)]
        public void NegationOperator_ReturnsQuantity_WithNegatedValue(double value)
        {
            var quantity = KinematicViscosity.FromSquareMetersPerSecond(value);
            Assert.Equal(KinematicViscosity.FromSquareMetersPerSecond(-value), -quantity);
        }
    }
}
