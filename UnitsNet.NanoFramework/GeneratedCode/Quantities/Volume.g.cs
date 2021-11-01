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
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Volume is the quantity of three-dimensional space enclosed by some closed boundary, for example, the space that a substance (solid, liquid, gas, or plasma) or shape occupies or contains.[1] Volume is often quantified numerically using the SI derived unit, the cubic metre. The volume of a container is generally understood to be the capacity of the container, i. e. the amount of fluid (gas or liquid) that the container could hold, rather than the amount of space the container itself displaces.
    /// </summary>
    public struct  Volume
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly VolumeUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public VolumeUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public Volume(double value, VolumeUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static VolumeUnit ConversionBaseUnit { get; } = VolumeUnit.CubicMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static Volume MaxValue { get; } = new Volume(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static Volume MinValue { get; } = new Volume(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static Volume Zero { get; } = new Volume(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get Volume in AcreFeet.
        /// </summary>
        public double AcreFeet => As(VolumeUnit.AcreFoot);

        /// <summary>
        ///     Get Volume in AuTablespoons.
        /// </summary>
        public double AuTablespoons => As(VolumeUnit.AuTablespoon);

        /// <summary>
        ///     Get Volume in BoardFeet.
        /// </summary>
        public double BoardFeet => As(VolumeUnit.BoardFoot);

        /// <summary>
        ///     Get Volume in Centiliters.
        /// </summary>
        public double Centiliters => As(VolumeUnit.Centiliter);

        /// <summary>
        ///     Get Volume in CubicCentimeters.
        /// </summary>
        public double CubicCentimeters => As(VolumeUnit.CubicCentimeter);

        /// <summary>
        ///     Get Volume in CubicDecimeters.
        /// </summary>
        public double CubicDecimeters => As(VolumeUnit.CubicDecimeter);

        /// <summary>
        ///     Get Volume in CubicFeet.
        /// </summary>
        public double CubicFeet => As(VolumeUnit.CubicFoot);

        /// <summary>
        ///     Get Volume in CubicHectometers.
        /// </summary>
        public double CubicHectometers => As(VolumeUnit.CubicHectometer);

        /// <summary>
        ///     Get Volume in CubicInches.
        /// </summary>
        public double CubicInches => As(VolumeUnit.CubicInch);

        /// <summary>
        ///     Get Volume in CubicKilometers.
        /// </summary>
        public double CubicKilometers => As(VolumeUnit.CubicKilometer);

        /// <summary>
        ///     Get Volume in CubicMeters.
        /// </summary>
        public double CubicMeters => As(VolumeUnit.CubicMeter);

        /// <summary>
        ///     Get Volume in CubicMicrometers.
        /// </summary>
        public double CubicMicrometers => As(VolumeUnit.CubicMicrometer);

        /// <summary>
        ///     Get Volume in CubicMiles.
        /// </summary>
        public double CubicMiles => As(VolumeUnit.CubicMile);

        /// <summary>
        ///     Get Volume in CubicMillimeters.
        /// </summary>
        public double CubicMillimeters => As(VolumeUnit.CubicMillimeter);

        /// <summary>
        ///     Get Volume in CubicYards.
        /// </summary>
        public double CubicYards => As(VolumeUnit.CubicYard);

        /// <summary>
        ///     Get Volume in DecausGallons.
        /// </summary>
        public double DecausGallons => As(VolumeUnit.DecausGallon);

        /// <summary>
        ///     Get Volume in Deciliters.
        /// </summary>
        public double Deciliters => As(VolumeUnit.Deciliter);

        /// <summary>
        ///     Get Volume in DeciusGallons.
        /// </summary>
        public double DeciusGallons => As(VolumeUnit.DeciusGallon);

        /// <summary>
        ///     Get Volume in HectocubicFeet.
        /// </summary>
        public double HectocubicFeet => As(VolumeUnit.HectocubicFoot);

        /// <summary>
        ///     Get Volume in HectocubicMeters.
        /// </summary>
        public double HectocubicMeters => As(VolumeUnit.HectocubicMeter);

        /// <summary>
        ///     Get Volume in Hectoliters.
        /// </summary>
        public double Hectoliters => As(VolumeUnit.Hectoliter);

        /// <summary>
        ///     Get Volume in HectousGallons.
        /// </summary>
        public double HectousGallons => As(VolumeUnit.HectousGallon);

        /// <summary>
        ///     Get Volume in ImperialBeerBarrels.
        /// </summary>
        public double ImperialBeerBarrels => As(VolumeUnit.ImperialBeerBarrel);

        /// <summary>
        ///     Get Volume in ImperialGallons.
        /// </summary>
        public double ImperialGallons => As(VolumeUnit.ImperialGallon);

        /// <summary>
        ///     Get Volume in ImperialOunces.
        /// </summary>
        public double ImperialOunces => As(VolumeUnit.ImperialOunce);

        /// <summary>
        ///     Get Volume in ImperialPints.
        /// </summary>
        public double ImperialPints => As(VolumeUnit.ImperialPint);

        /// <summary>
        ///     Get Volume in KilocubicFeet.
        /// </summary>
        public double KilocubicFeet => As(VolumeUnit.KilocubicFoot);

        /// <summary>
        ///     Get Volume in KilocubicMeters.
        /// </summary>
        public double KilocubicMeters => As(VolumeUnit.KilocubicMeter);

        /// <summary>
        ///     Get Volume in KiloimperialGallons.
        /// </summary>
        public double KiloimperialGallons => As(VolumeUnit.KiloimperialGallon);

        /// <summary>
        ///     Get Volume in Kiloliters.
        /// </summary>
        public double Kiloliters => As(VolumeUnit.Kiloliter);

        /// <summary>
        ///     Get Volume in KilousGallons.
        /// </summary>
        public double KilousGallons => As(VolumeUnit.KilousGallon);

        /// <summary>
        ///     Get Volume in Liters.
        /// </summary>
        public double Liters => As(VolumeUnit.Liter);

        /// <summary>
        ///     Get Volume in MegacubicFeet.
        /// </summary>
        public double MegacubicFeet => As(VolumeUnit.MegacubicFoot);

        /// <summary>
        ///     Get Volume in MegaimperialGallons.
        /// </summary>
        public double MegaimperialGallons => As(VolumeUnit.MegaimperialGallon);

        /// <summary>
        ///     Get Volume in Megaliters.
        /// </summary>
        public double Megaliters => As(VolumeUnit.Megaliter);

        /// <summary>
        ///     Get Volume in MegausGallons.
        /// </summary>
        public double MegausGallons => As(VolumeUnit.MegausGallon);

        /// <summary>
        ///     Get Volume in MetricCups.
        /// </summary>
        public double MetricCups => As(VolumeUnit.MetricCup);

        /// <summary>
        ///     Get Volume in MetricTeaspoons.
        /// </summary>
        public double MetricTeaspoons => As(VolumeUnit.MetricTeaspoon);

        /// <summary>
        ///     Get Volume in Microliters.
        /// </summary>
        public double Microliters => As(VolumeUnit.Microliter);

        /// <summary>
        ///     Get Volume in Milliliters.
        /// </summary>
        public double Milliliters => As(VolumeUnit.Milliliter);

        /// <summary>
        ///     Get Volume in OilBarrels.
        /// </summary>
        public double OilBarrels => As(VolumeUnit.OilBarrel);

        /// <summary>
        ///     Get Volume in UkTablespoons.
        /// </summary>
        public double UkTablespoons => As(VolumeUnit.UkTablespoon);

        /// <summary>
        ///     Get Volume in UsBeerBarrels.
        /// </summary>
        public double UsBeerBarrels => As(VolumeUnit.UsBeerBarrel);

        /// <summary>
        ///     Get Volume in UsCustomaryCups.
        /// </summary>
        public double UsCustomaryCups => As(VolumeUnit.UsCustomaryCup);

        /// <summary>
        ///     Get Volume in UsGallons.
        /// </summary>
        public double UsGallons => As(VolumeUnit.UsGallon);

        /// <summary>
        ///     Get Volume in UsLegalCups.
        /// </summary>
        public double UsLegalCups => As(VolumeUnit.UsLegalCup);

        /// <summary>
        ///     Get Volume in UsOunces.
        /// </summary>
        public double UsOunces => As(VolumeUnit.UsOunce);

        /// <summary>
        ///     Get Volume in UsPints.
        /// </summary>
        public double UsPints => As(VolumeUnit.UsPint);

        /// <summary>
        ///     Get Volume in UsQuarts.
        /// </summary>
        public double UsQuarts => As(VolumeUnit.UsQuart);

        /// <summary>
        ///     Get Volume in UsTablespoons.
        /// </summary>
        public double UsTablespoons => As(VolumeUnit.UsTablespoon);

        /// <summary>
        ///     Get Volume in UsTeaspoons.
        /// </summary>
        public double UsTeaspoons => As(VolumeUnit.UsTeaspoon);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get Volume from AcreFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromAcreFeet(double acrefeet) => new Volume(acrefeet, VolumeUnit.AcreFoot);

        /// <summary>
        ///     Get Volume from AuTablespoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromAuTablespoons(double autablespoons) => new Volume(autablespoons, VolumeUnit.AuTablespoon);

        /// <summary>
        ///     Get Volume from BoardFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromBoardFeet(double boardfeet) => new Volume(boardfeet, VolumeUnit.BoardFoot);

        /// <summary>
        ///     Get Volume from Centiliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCentiliters(double centiliters) => new Volume(centiliters, VolumeUnit.Centiliter);

        /// <summary>
        ///     Get Volume from CubicCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicCentimeters(double cubiccentimeters) => new Volume(cubiccentimeters, VolumeUnit.CubicCentimeter);

        /// <summary>
        ///     Get Volume from CubicDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicDecimeters(double cubicdecimeters) => new Volume(cubicdecimeters, VolumeUnit.CubicDecimeter);

        /// <summary>
        ///     Get Volume from CubicFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicFeet(double cubicfeet) => new Volume(cubicfeet, VolumeUnit.CubicFoot);

        /// <summary>
        ///     Get Volume from CubicHectometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicHectometers(double cubichectometers) => new Volume(cubichectometers, VolumeUnit.CubicHectometer);

        /// <summary>
        ///     Get Volume from CubicInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicInches(double cubicinches) => new Volume(cubicinches, VolumeUnit.CubicInch);

        /// <summary>
        ///     Get Volume from CubicKilometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicKilometers(double cubickilometers) => new Volume(cubickilometers, VolumeUnit.CubicKilometer);

        /// <summary>
        ///     Get Volume from CubicMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicMeters(double cubicmeters) => new Volume(cubicmeters, VolumeUnit.CubicMeter);

        /// <summary>
        ///     Get Volume from CubicMicrometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicMicrometers(double cubicmicrometers) => new Volume(cubicmicrometers, VolumeUnit.CubicMicrometer);

        /// <summary>
        ///     Get Volume from CubicMiles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicMiles(double cubicmiles) => new Volume(cubicmiles, VolumeUnit.CubicMile);

        /// <summary>
        ///     Get Volume from CubicMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicMillimeters(double cubicmillimeters) => new Volume(cubicmillimeters, VolumeUnit.CubicMillimeter);

        /// <summary>
        ///     Get Volume from CubicYards.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromCubicYards(double cubicyards) => new Volume(cubicyards, VolumeUnit.CubicYard);

        /// <summary>
        ///     Get Volume from DecausGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromDecausGallons(double decausgallons) => new Volume(decausgallons, VolumeUnit.DecausGallon);

        /// <summary>
        ///     Get Volume from Deciliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromDeciliters(double deciliters) => new Volume(deciliters, VolumeUnit.Deciliter);

        /// <summary>
        ///     Get Volume from DeciusGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromDeciusGallons(double deciusgallons) => new Volume(deciusgallons, VolumeUnit.DeciusGallon);

        /// <summary>
        ///     Get Volume from HectocubicFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromHectocubicFeet(double hectocubicfeet) => new Volume(hectocubicfeet, VolumeUnit.HectocubicFoot);

        /// <summary>
        ///     Get Volume from HectocubicMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromHectocubicMeters(double hectocubicmeters) => new Volume(hectocubicmeters, VolumeUnit.HectocubicMeter);

        /// <summary>
        ///     Get Volume from Hectoliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromHectoliters(double hectoliters) => new Volume(hectoliters, VolumeUnit.Hectoliter);

        /// <summary>
        ///     Get Volume from HectousGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromHectousGallons(double hectousgallons) => new Volume(hectousgallons, VolumeUnit.HectousGallon);

        /// <summary>
        ///     Get Volume from ImperialBeerBarrels.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromImperialBeerBarrels(double imperialbeerbarrels) => new Volume(imperialbeerbarrels, VolumeUnit.ImperialBeerBarrel);

        /// <summary>
        ///     Get Volume from ImperialGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromImperialGallons(double imperialgallons) => new Volume(imperialgallons, VolumeUnit.ImperialGallon);

        /// <summary>
        ///     Get Volume from ImperialOunces.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromImperialOunces(double imperialounces) => new Volume(imperialounces, VolumeUnit.ImperialOunce);

        /// <summary>
        ///     Get Volume from ImperialPints.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromImperialPints(double imperialpints) => new Volume(imperialpints, VolumeUnit.ImperialPint);

        /// <summary>
        ///     Get Volume from KilocubicFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromKilocubicFeet(double kilocubicfeet) => new Volume(kilocubicfeet, VolumeUnit.KilocubicFoot);

        /// <summary>
        ///     Get Volume from KilocubicMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromKilocubicMeters(double kilocubicmeters) => new Volume(kilocubicmeters, VolumeUnit.KilocubicMeter);

        /// <summary>
        ///     Get Volume from KiloimperialGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromKiloimperialGallons(double kiloimperialgallons) => new Volume(kiloimperialgallons, VolumeUnit.KiloimperialGallon);

        /// <summary>
        ///     Get Volume from Kiloliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromKiloliters(double kiloliters) => new Volume(kiloliters, VolumeUnit.Kiloliter);

        /// <summary>
        ///     Get Volume from KilousGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromKilousGallons(double kilousgallons) => new Volume(kilousgallons, VolumeUnit.KilousGallon);

        /// <summary>
        ///     Get Volume from Liters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromLiters(double liters) => new Volume(liters, VolumeUnit.Liter);

        /// <summary>
        ///     Get Volume from MegacubicFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromMegacubicFeet(double megacubicfeet) => new Volume(megacubicfeet, VolumeUnit.MegacubicFoot);

        /// <summary>
        ///     Get Volume from MegaimperialGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromMegaimperialGallons(double megaimperialgallons) => new Volume(megaimperialgallons, VolumeUnit.MegaimperialGallon);

        /// <summary>
        ///     Get Volume from Megaliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromMegaliters(double megaliters) => new Volume(megaliters, VolumeUnit.Megaliter);

        /// <summary>
        ///     Get Volume from MegausGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromMegausGallons(double megausgallons) => new Volume(megausgallons, VolumeUnit.MegausGallon);

        /// <summary>
        ///     Get Volume from MetricCups.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromMetricCups(double metriccups) => new Volume(metriccups, VolumeUnit.MetricCup);

        /// <summary>
        ///     Get Volume from MetricTeaspoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromMetricTeaspoons(double metricteaspoons) => new Volume(metricteaspoons, VolumeUnit.MetricTeaspoon);

        /// <summary>
        ///     Get Volume from Microliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromMicroliters(double microliters) => new Volume(microliters, VolumeUnit.Microliter);

        /// <summary>
        ///     Get Volume from Milliliters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromMilliliters(double milliliters) => new Volume(milliliters, VolumeUnit.Milliliter);

        /// <summary>
        ///     Get Volume from OilBarrels.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromOilBarrels(double oilbarrels) => new Volume(oilbarrels, VolumeUnit.OilBarrel);

        /// <summary>
        ///     Get Volume from UkTablespoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUkTablespoons(double uktablespoons) => new Volume(uktablespoons, VolumeUnit.UkTablespoon);

        /// <summary>
        ///     Get Volume from UsBeerBarrels.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsBeerBarrels(double usbeerbarrels) => new Volume(usbeerbarrels, VolumeUnit.UsBeerBarrel);

        /// <summary>
        ///     Get Volume from UsCustomaryCups.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsCustomaryCups(double uscustomarycups) => new Volume(uscustomarycups, VolumeUnit.UsCustomaryCup);

        /// <summary>
        ///     Get Volume from UsGallons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsGallons(double usgallons) => new Volume(usgallons, VolumeUnit.UsGallon);

        /// <summary>
        ///     Get Volume from UsLegalCups.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsLegalCups(double uslegalcups) => new Volume(uslegalcups, VolumeUnit.UsLegalCup);

        /// <summary>
        ///     Get Volume from UsOunces.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsOunces(double usounces) => new Volume(usounces, VolumeUnit.UsOunce);

        /// <summary>
        ///     Get Volume from UsPints.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsPints(double uspints) => new Volume(uspints, VolumeUnit.UsPint);

        /// <summary>
        ///     Get Volume from UsQuarts.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsQuarts(double usquarts) => new Volume(usquarts, VolumeUnit.UsQuart);

        /// <summary>
        ///     Get Volume from UsTablespoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsTablespoons(double ustablespoons) => new Volume(ustablespoons, VolumeUnit.UsTablespoon);

        /// <summary>
        ///     Get Volume from UsTeaspoons.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static Volume FromUsTeaspoons(double usteaspoons) => new Volume(usteaspoons, VolumeUnit.UsTeaspoon);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="VolumeUnit" /> to <see cref="Volume" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>Volume unit value.</returns>
        public static Volume From(double value, VolumeUnit fromUnit)
        {
            return new Volume(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(VolumeUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public Volume ToUnit(VolumeUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new Volume(convertedValue, unit);
        }


        /// <summary>
        ///     Converts the current value + unit to the base unit.
        ///     This is typically the first step in converting from one unit to another.
        /// </summary>
        /// <returns>The value in the base unit representation.</returns>
        private double GetValueInBaseUnit()
        {
            switch(Unit)
            {
                case VolumeUnit.AcreFoot: return _value/0.000810714;
                case VolumeUnit.AuTablespoon: return _value*2e-5;
                case VolumeUnit.BoardFoot: return _value*2.3597372158e-3;
                case VolumeUnit.Centiliter: return (_value/1e3) * 1e-2d;
                case VolumeUnit.CubicCentimeter: return _value/1e6;
                case VolumeUnit.CubicDecimeter: return _value/1e3;
                case VolumeUnit.CubicFoot: return _value*0.0283168;
                case VolumeUnit.CubicHectometer: return _value*1e6;
                case VolumeUnit.CubicInch: return _value*1.6387*1e-5;
                case VolumeUnit.CubicKilometer: return _value*1e9;
                case VolumeUnit.CubicMeter: return _value;
                case VolumeUnit.CubicMicrometer: return _value/1e18;
                case VolumeUnit.CubicMile: return _value*4.16818182544058e9;
                case VolumeUnit.CubicMillimeter: return _value/1e9;
                case VolumeUnit.CubicYard: return _value*0.764554858;
                case VolumeUnit.DecausGallon: return (_value*0.00378541) * 1e1d;
                case VolumeUnit.Deciliter: return (_value/1e3) * 1e-1d;
                case VolumeUnit.DeciusGallon: return (_value*0.00378541) * 1e-1d;
                case VolumeUnit.HectocubicFoot: return (_value*0.0283168) * 1e2d;
                case VolumeUnit.HectocubicMeter: return (_value) * 1e2d;
                case VolumeUnit.Hectoliter: return (_value/1e3) * 1e2d;
                case VolumeUnit.HectousGallon: return (_value*0.00378541) * 1e2d;
                case VolumeUnit.ImperialBeerBarrel: return _value*0.16365924;
                case VolumeUnit.ImperialGallon: return _value*0.00454609000000181429905810072407;
                case VolumeUnit.ImperialOunce: return _value*2.8413062499962901241875439064617e-5;
                case VolumeUnit.ImperialPint: return _value * 5.6826125e-4;
                case VolumeUnit.KilocubicFoot: return (_value*0.0283168) * 1e3d;
                case VolumeUnit.KilocubicMeter: return (_value) * 1e3d;
                case VolumeUnit.KiloimperialGallon: return (_value*0.00454609000000181429905810072407) * 1e3d;
                case VolumeUnit.Kiloliter: return (_value/1e3) * 1e3d;
                case VolumeUnit.KilousGallon: return (_value*0.00378541) * 1e3d;
                case VolumeUnit.Liter: return _value/1e3;
                case VolumeUnit.MegacubicFoot: return (_value*0.0283168) * 1e6d;
                case VolumeUnit.MegaimperialGallon: return (_value*0.00454609000000181429905810072407) * 1e6d;
                case VolumeUnit.Megaliter: return (_value/1e3) * 1e6d;
                case VolumeUnit.MegausGallon: return (_value*0.00378541) * 1e6d;
                case VolumeUnit.MetricCup: return _value*0.00025;
                case VolumeUnit.MetricTeaspoon: return _value*0.5e-5;
                case VolumeUnit.Microliter: return (_value/1e3) * 1e-6d;
                case VolumeUnit.Milliliter: return (_value/1e3) * 1e-3d;
                case VolumeUnit.OilBarrel: return _value*0.158987294928;
                case VolumeUnit.UkTablespoon: return _value*1.5e-5;
                case VolumeUnit.UsBeerBarrel: return _value*0.1173477658;
                case VolumeUnit.UsCustomaryCup: return _value*0.0002365882365;
                case VolumeUnit.UsGallon: return _value*0.00378541;
                case VolumeUnit.UsLegalCup: return _value*0.00024;
                case VolumeUnit.UsOunce: return _value*2.957352956253760505068307980135e-5;
                case VolumeUnit.UsPint: return _value*4.73176473e-4;
                case VolumeUnit.UsQuart: return _value*9.46352946e-4;
                case VolumeUnit.UsTablespoon: return _value*1.478676478125e-5;
                case VolumeUnit.UsTeaspoon: return _value*4.92892159375e-6;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(VolumeUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case VolumeUnit.AcreFoot: return baseUnitValue*0.000810714;
                case VolumeUnit.AuTablespoon: return baseUnitValue/2e-5;
                case VolumeUnit.BoardFoot: return baseUnitValue/2.3597372158e-3;
                case VolumeUnit.Centiliter: return (baseUnitValue*1e3) / 1e-2d;
                case VolumeUnit.CubicCentimeter: return baseUnitValue*1e6;
                case VolumeUnit.CubicDecimeter: return baseUnitValue*1e3;
                case VolumeUnit.CubicFoot: return baseUnitValue/0.0283168;
                case VolumeUnit.CubicHectometer: return baseUnitValue/1e6;
                case VolumeUnit.CubicInch: return baseUnitValue/(1.6387*1e-5);
                case VolumeUnit.CubicKilometer: return baseUnitValue/1e9;
                case VolumeUnit.CubicMeter: return baseUnitValue;
                case VolumeUnit.CubicMicrometer: return baseUnitValue*1e18;
                case VolumeUnit.CubicMile: return baseUnitValue/4.16818182544058e9;
                case VolumeUnit.CubicMillimeter: return baseUnitValue*1e9;
                case VolumeUnit.CubicYard: return baseUnitValue/0.764554858;
                case VolumeUnit.DecausGallon: return (baseUnitValue/0.00378541) / 1e1d;
                case VolumeUnit.Deciliter: return (baseUnitValue*1e3) / 1e-1d;
                case VolumeUnit.DeciusGallon: return (baseUnitValue/0.00378541) / 1e-1d;
                case VolumeUnit.HectocubicFoot: return (baseUnitValue/0.0283168) / 1e2d;
                case VolumeUnit.HectocubicMeter: return (baseUnitValue) / 1e2d;
                case VolumeUnit.Hectoliter: return (baseUnitValue*1e3) / 1e2d;
                case VolumeUnit.HectousGallon: return (baseUnitValue/0.00378541) / 1e2d;
                case VolumeUnit.ImperialBeerBarrel: return baseUnitValue/0.16365924;
                case VolumeUnit.ImperialGallon: return baseUnitValue/0.00454609000000181429905810072407;
                case VolumeUnit.ImperialOunce: return baseUnitValue/2.8413062499962901241875439064617e-5;
                case VolumeUnit.ImperialPint: return baseUnitValue / 5.6826125e-4;
                case VolumeUnit.KilocubicFoot: return (baseUnitValue/0.0283168) / 1e3d;
                case VolumeUnit.KilocubicMeter: return (baseUnitValue) / 1e3d;
                case VolumeUnit.KiloimperialGallon: return (baseUnitValue/0.00454609000000181429905810072407) / 1e3d;
                case VolumeUnit.Kiloliter: return (baseUnitValue*1e3) / 1e3d;
                case VolumeUnit.KilousGallon: return (baseUnitValue/0.00378541) / 1e3d;
                case VolumeUnit.Liter: return baseUnitValue*1e3;
                case VolumeUnit.MegacubicFoot: return (baseUnitValue/0.0283168) / 1e6d;
                case VolumeUnit.MegaimperialGallon: return (baseUnitValue/0.00454609000000181429905810072407) / 1e6d;
                case VolumeUnit.Megaliter: return (baseUnitValue*1e3) / 1e6d;
                case VolumeUnit.MegausGallon: return (baseUnitValue/0.00378541) / 1e6d;
                case VolumeUnit.MetricCup: return baseUnitValue/0.00025;
                case VolumeUnit.MetricTeaspoon: return baseUnitValue/0.5e-5;
                case VolumeUnit.Microliter: return (baseUnitValue*1e3) / 1e-6d;
                case VolumeUnit.Milliliter: return (baseUnitValue*1e3) / 1e-3d;
                case VolumeUnit.OilBarrel: return baseUnitValue/0.158987294928;
                case VolumeUnit.UkTablespoon: return baseUnitValue/1.5e-5;
                case VolumeUnit.UsBeerBarrel: return baseUnitValue/0.1173477658;
                case VolumeUnit.UsCustomaryCup: return baseUnitValue/0.0002365882365;
                case VolumeUnit.UsGallon: return baseUnitValue/0.00378541;
                case VolumeUnit.UsLegalCup: return baseUnitValue/0.00024;
                case VolumeUnit.UsOunce: return baseUnitValue/2.957352956253760505068307980135e-5;
                case VolumeUnit.UsPint: return baseUnitValue/4.73176473e-4;
                case VolumeUnit.UsQuart: return baseUnitValue/9.46352946e-4;
                case VolumeUnit.UsTablespoon: return baseUnitValue/1.478676478125e-5;
                case VolumeUnit.UsTeaspoon: return baseUnitValue/4.92892159375e-6;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

