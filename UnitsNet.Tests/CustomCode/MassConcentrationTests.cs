﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated (once) by \generate-code.bat, but will not be
//     regenerated when it already exists. The purpose of creating this file is to make
//     it easier to remember to implement all the unit conversion test cases.
//
//     Whenever a new unit is added to this quantity and \generate-code.bat is run,
//     the base test class will get a new abstract property and cause a compile error
//     in this derived class, reminding the developer to implement the test case
//     for the new unit.
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
using UnitsNet.Units;
using Xunit;

namespace UnitsNet.Tests.CustomCode
{
    public class MassConcentrationTests : MassConcentrationTestsBase
    {
        protected override bool SupportsSIUnitSystem => false;

        #region Unit Conversion Coefficients
        protected override double PicogramsPerLiterInOneKilogramPerCubicMeter => 1e12;
        protected override double PicogramsPerMicroliterInOneKilogramPerCubicMeter => 1e6;
        protected override double PicogramsPerDeciliterInOneKilogramPerCubicMeter => 1e11;
        protected override double NanogramsPerLiterInOneKilogramPerCubicMeter => 1e9;
        protected override double NanogramsPerMicroliterInOneKilogramPerCubicMeter => 1e3;
        protected override double PicogramsPerMilliliterInOneKilogramPerCubicMeter => 1e9;
        protected override double MicrogramsPerCubicMeterInOneKilogramPerCubicMeter => 1e9;
        protected override double NanogramsPerDeciliterInOneKilogramPerCubicMeter => 1e8;
        protected override double NanogramsPerMilliliterInOneKilogramPerCubicMeter => 1e6;
        protected override double MicrogramsPerLiterInOneKilogramPerCubicMeter => 1e6;
        protected override double MicrogramsPerMicroliterInOneKilogramPerCubicMeter => 1;
        protected override double MilligramsPerCubicMeterInOneKilogramPerCubicMeter => 1e6;
        protected override double MicrogramsPerDeciliterInOneKilogramPerCubicMeter => 1e5;
        protected override double MicrogramsPerMilliliterInOneKilogramPerCubicMeter => 1e3;
        protected override double GramsPerCubicMeterInOneKilogramPerCubicMeter => 1e3;
        protected override double MilligramsPerLiterInOneKilogramPerCubicMeter => 1e3;
        protected override double MilligramsPerMicroliterInOneKilogramPerCubicMeter => 1e-3;
        protected override double CentigramsPerLiterInOneKilogramPerCubicMeter => 1e2;
        protected override double CentigramsPerMicroliterInOneKilogramPerCubicMeter => 1e-4;
        protected override double MilligramsPerDeciliterInOneKilogramPerCubicMeter => 1e2;
        protected override double MilligramsPerMilliliterInOneKilogramPerCubicMeter => 1;
        protected override double GramsPerLiterInOneKilogramPerCubicMeter => 1;
        protected override double GramsPerMicroliterInOneKilogramPerCubicMeter => 1e-6;
        protected override double KilogramsPerCubicMeterInOneKilogramPerCubicMeter => 1;
        protected override double CentigramsPerDeciliterInOneKilogramPerCubicMeter => 1e1;
        protected override double DecigramsPerDeciliterInOneKilogramPerCubicMeter => 1;
        protected override double DecigramsPerLiterInOneKilogramPerCubicMeter => 1e1;
        protected override double DecigramsPerMicroliterInOneKilogramPerCubicMeter => 1e-5;
        protected override double CentigramsPerMilliliterInOneKilogramPerCubicMeter => 1e-1;
        protected override double GramsPerDeciliterInOneKilogramPerCubicMeter => 1e-1;
        protected override double DecigramsPerMilliliterInOneKilogramPerCubicMeter => 1e-2;
        protected override double KilogramsPerLiterInOneKilogramPerCubicMeter => 1e-3;
        protected override double GramsPerMilliliterInOneKilogramPerCubicMeter => 1e-3;
        protected override double GramsPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-3;
        protected override double TonnesPerCubicMeterInOneKilogramPerCubicMeter => 1e-3;
        protected override double GramsPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-6;
        protected override double KilogramsPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-6;
        protected override double KilogramsPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-9;
        protected override double TonnesPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-9;
        protected override double TonnesPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-12;

        protected override double PoundsPerImperialGallonInOneKilogramPerCubicMeter => 1.002241e-2;
        protected override double KilopoundsPerCubicFootInOneKilogramPerCubicMeter => 6.242796e-5;
        protected override double KilopoundsPerCubicInchInOneKilogramPerCubicMeter => 3.6127292e-8;
        protected override double PoundsPerCubicFootInOneKilogramPerCubicMeter => 6.242796e-2;
        protected override double PoundsPerCubicInchInOneKilogramPerCubicMeter => 3.61272923e-5;
        protected override double PoundsPerUSGallonInOneKilogramPerCubicMeter => 8.3454045e-3;
        protected override double SlugsPerCubicFootInOneKilogramPerCubicMeter => 0.00194032;

        protected override double OuncesPerImperialGallonInOneKilogramPerCubicMeter => 0.1603586720609;

        protected override double OuncesPerUSGallonInOneKilogramPerCubicMeter => 0.1335264711843;
        #endregion

        [Theory]
        [InlineData(60.02, MassConcentrationUnit.KilogramPerCubicMeter,
                    58.443, MolarMassUnit.GramPerMole,
                    1026.98355, MolarityUnit.MolesPerCubicMeter)]    // test from JonathanDavies626
        public void MolarityFromMassConcentrationAndMolarMass(
            double massConcValue, MassConcentrationUnit massConcUnit,
            double molarMassValue, MolarMassUnit molarMassUnit,
            double expectedMolarityValue, MolarityUnit expectedMolarityUnit, double tolerance = 1e-5)
        {
            var massConcentration = new MassConcentration(massConcValue, massConcUnit);
            var molarMass = new MolarMass(molarMassValue, molarMassUnit);

            Molarity molarity = massConcentration.ToMolarity(molarMass);     // molarity / molarMass

            AssertEx.EqualTolerance(expectedMolarityValue, molarity.As(expectedMolarityUnit), tolerance);
        }

        [Theory]
        [InlineData(10, DensityUnit.GramPerCubicMeter,
                    5, MassConcentrationUnit.GramPerCubicMeter,
                    0.5, VolumeConcentrationUnit.DecimalFraction)]  // synthetic data
        public void VolumeConcentrationFromMassConcentrationAndDensity(
            double componentDensityValue, DensityUnit componentDensityUnit,
            double massConcValue, MassConcentrationUnit masConcUnit,
            double expectedVolumeConcValue, VolumeConcentrationUnit expectedVolumeConcUnit, double tolerence = 1e-5)
        {
            var density = new Density(componentDensityValue, componentDensityUnit);
            var massConcentration = new MassConcentration(massConcValue, masConcUnit);

            VolumeConcentration volumeConcentration = massConcentration.ToVolumeConcentration(density); // massConcentration / density;

            AssertEx.EqualTolerance(expectedVolumeConcValue, volumeConcentration.As(expectedVolumeConcUnit), tolerence);
        }

        [Theory]
        [InlineData(2, MassConcentrationUnit.KilogramPerCubicMeter,
                    3, VolumeUnit.CubicMeter,
                    6, MassUnit.Kilogram)]  // synthetic data
        public static void ComponentMassFromMassConcentrationAndSolutionVolume(
            double massConcValue, MassConcentrationUnit massConcUnit,
            double volumeValue, VolumeUnit volumeUnit,
            double expectedMassValue, MassUnit expectedMassUnit, double tolerance = 1e-5)
        {
            var massConcentration = new MassConcentration(massConcValue, massConcUnit);
            var volume = new Volume(volumeValue, volumeUnit);

            Mass massComponent = massConcentration * volume;

            AssertEx.EqualTolerance(expectedMassValue, massComponent.As(expectedMassUnit), tolerance);
        }

        [Fact(Skip = "No ConversionBaseUnit defined: see https://github.com/angularsen/UnitsNet/issues/651")]
        public void DefaultSIUnitIsKgPerCubicMeter()
        {
            var massConcentration = new MassConcentration(1, UnitSystem.SI);

            Assert.Equal(MassConcentrationUnit.KilogramPerCubicMeter, massConcentration.Unit); // MassConcentration.ConversionBaseUnit = KilogramPerCubicMeter
        }

        [Fact]
        public void DefaultUnitTypeRespectedForCustomUnitSystem()
        {
            UnitSystem customSystem = new UnitSystem(new BaseUnits(LengthUnit.Millimeter, MassUnit.Gram, DurationUnit.Millisecond,
                ElectricCurrentUnit.Ampere, TemperatureUnit.DegreeCelsius, AmountOfSubstanceUnit.Mole, LuminousIntensityUnit.Candela));

            var massConcentration = new MassConcentration(1, customSystem);

            Assert.Equal(MassConcentrationUnit.GramPerCubicMillimeter, massConcentration.Unit);
        }

    }
}
