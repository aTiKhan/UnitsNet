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
    ///     The magnitude of force per unit length.
    /// </summary>
    public struct  ForcePerLength
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ForcePerLengthUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ForcePerLengthUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ForcePerLength(double value, ForcePerLengthUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ForcePerLengthUnit ConversionBaseUnit { get; } = ForcePerLengthUnit.NewtonPerMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ForcePerLength MaxValue { get; } = new ForcePerLength(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ForcePerLength MinValue { get; } = new ForcePerLength(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ForcePerLength Zero { get; } = new ForcePerLength(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get ForcePerLength in CentinewtonsPerCentimeter.
        /// </summary>
        public double CentinewtonsPerCentimeter => As(ForcePerLengthUnit.CentinewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in CentinewtonsPerMeter.
        /// </summary>
        public double CentinewtonsPerMeter => As(ForcePerLengthUnit.CentinewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in CentinewtonsPerMillimeter.
        /// </summary>
        public double CentinewtonsPerMillimeter => As(ForcePerLengthUnit.CentinewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in DecanewtonsPerCentimeter.
        /// </summary>
        public double DecanewtonsPerCentimeter => As(ForcePerLengthUnit.DecanewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in DecanewtonsPerMeter.
        /// </summary>
        public double DecanewtonsPerMeter => As(ForcePerLengthUnit.DecanewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in DecanewtonsPerMillimeter.
        /// </summary>
        public double DecanewtonsPerMillimeter => As(ForcePerLengthUnit.DecanewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in DecinewtonsPerCentimeter.
        /// </summary>
        public double DecinewtonsPerCentimeter => As(ForcePerLengthUnit.DecinewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in DecinewtonsPerMeter.
        /// </summary>
        public double DecinewtonsPerMeter => As(ForcePerLengthUnit.DecinewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in DecinewtonsPerMillimeter.
        /// </summary>
        public double DecinewtonsPerMillimeter => As(ForcePerLengthUnit.DecinewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in KilogramsForcePerCentimeter.
        /// </summary>
        public double KilogramsForcePerCentimeter => As(ForcePerLengthUnit.KilogramForcePerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in KilogramsForcePerMeter.
        /// </summary>
        public double KilogramsForcePerMeter => As(ForcePerLengthUnit.KilogramForcePerMeter);

        /// <summary>
        ///     Get ForcePerLength in KilogramsForcePerMillimeter.
        /// </summary>
        public double KilogramsForcePerMillimeter => As(ForcePerLengthUnit.KilogramForcePerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in KilonewtonsPerCentimeter.
        /// </summary>
        public double KilonewtonsPerCentimeter => As(ForcePerLengthUnit.KilonewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in KilonewtonsPerMeter.
        /// </summary>
        public double KilonewtonsPerMeter => As(ForcePerLengthUnit.KilonewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in KilonewtonsPerMillimeter.
        /// </summary>
        public double KilonewtonsPerMillimeter => As(ForcePerLengthUnit.KilonewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in KilopoundsForcePerFoot.
        /// </summary>
        public double KilopoundsForcePerFoot => As(ForcePerLengthUnit.KilopoundForcePerFoot);

        /// <summary>
        ///     Get ForcePerLength in KilopoundsForcePerInch.
        /// </summary>
        public double KilopoundsForcePerInch => As(ForcePerLengthUnit.KilopoundForcePerInch);

        /// <summary>
        ///     Get ForcePerLength in MeganewtonsPerCentimeter.
        /// </summary>
        public double MeganewtonsPerCentimeter => As(ForcePerLengthUnit.MeganewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in MeganewtonsPerMeter.
        /// </summary>
        public double MeganewtonsPerMeter => As(ForcePerLengthUnit.MeganewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in MeganewtonsPerMillimeter.
        /// </summary>
        public double MeganewtonsPerMillimeter => As(ForcePerLengthUnit.MeganewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in MicronewtonsPerCentimeter.
        /// </summary>
        public double MicronewtonsPerCentimeter => As(ForcePerLengthUnit.MicronewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in MicronewtonsPerMeter.
        /// </summary>
        public double MicronewtonsPerMeter => As(ForcePerLengthUnit.MicronewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in MicronewtonsPerMillimeter.
        /// </summary>
        public double MicronewtonsPerMillimeter => As(ForcePerLengthUnit.MicronewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in MillinewtonsPerCentimeter.
        /// </summary>
        public double MillinewtonsPerCentimeter => As(ForcePerLengthUnit.MillinewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in MillinewtonsPerMeter.
        /// </summary>
        public double MillinewtonsPerMeter => As(ForcePerLengthUnit.MillinewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in MillinewtonsPerMillimeter.
        /// </summary>
        public double MillinewtonsPerMillimeter => As(ForcePerLengthUnit.MillinewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in NanonewtonsPerCentimeter.
        /// </summary>
        public double NanonewtonsPerCentimeter => As(ForcePerLengthUnit.NanonewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in NanonewtonsPerMeter.
        /// </summary>
        public double NanonewtonsPerMeter => As(ForcePerLengthUnit.NanonewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in NanonewtonsPerMillimeter.
        /// </summary>
        public double NanonewtonsPerMillimeter => As(ForcePerLengthUnit.NanonewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in NewtonsPerCentimeter.
        /// </summary>
        public double NewtonsPerCentimeter => As(ForcePerLengthUnit.NewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in NewtonsPerMeter.
        /// </summary>
        public double NewtonsPerMeter => As(ForcePerLengthUnit.NewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength in NewtonsPerMillimeter.
        /// </summary>
        public double NewtonsPerMillimeter => As(ForcePerLengthUnit.NewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength in PoundsForcePerFoot.
        /// </summary>
        public double PoundsForcePerFoot => As(ForcePerLengthUnit.PoundForcePerFoot);

        /// <summary>
        ///     Get ForcePerLength in PoundsForcePerInch.
        /// </summary>
        public double PoundsForcePerInch => As(ForcePerLengthUnit.PoundForcePerInch);

        /// <summary>
        ///     Get ForcePerLength in PoundsForcePerYard.
        /// </summary>
        public double PoundsForcePerYard => As(ForcePerLengthUnit.PoundForcePerYard);

        /// <summary>
        ///     Get ForcePerLength in TonnesForcePerCentimeter.
        /// </summary>
        public double TonnesForcePerCentimeter => As(ForcePerLengthUnit.TonneForcePerCentimeter);

        /// <summary>
        ///     Get ForcePerLength in TonnesForcePerMeter.
        /// </summary>
        public double TonnesForcePerMeter => As(ForcePerLengthUnit.TonneForcePerMeter);

        /// <summary>
        ///     Get ForcePerLength in TonnesForcePerMillimeter.
        /// </summary>
        public double TonnesForcePerMillimeter => As(ForcePerLengthUnit.TonneForcePerMillimeter);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ForcePerLength from CentinewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromCentinewtonsPerCentimeter(double centinewtonspercentimeter) => new ForcePerLength(centinewtonspercentimeter, ForcePerLengthUnit.CentinewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from CentinewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromCentinewtonsPerMeter(double centinewtonspermeter) => new ForcePerLength(centinewtonspermeter, ForcePerLengthUnit.CentinewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from CentinewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromCentinewtonsPerMillimeter(double centinewtonspermillimeter) => new ForcePerLength(centinewtonspermillimeter, ForcePerLengthUnit.CentinewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from DecanewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromDecanewtonsPerCentimeter(double decanewtonspercentimeter) => new ForcePerLength(decanewtonspercentimeter, ForcePerLengthUnit.DecanewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from DecanewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromDecanewtonsPerMeter(double decanewtonspermeter) => new ForcePerLength(decanewtonspermeter, ForcePerLengthUnit.DecanewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from DecanewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromDecanewtonsPerMillimeter(double decanewtonspermillimeter) => new ForcePerLength(decanewtonspermillimeter, ForcePerLengthUnit.DecanewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from DecinewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromDecinewtonsPerCentimeter(double decinewtonspercentimeter) => new ForcePerLength(decinewtonspercentimeter, ForcePerLengthUnit.DecinewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from DecinewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromDecinewtonsPerMeter(double decinewtonspermeter) => new ForcePerLength(decinewtonspermeter, ForcePerLengthUnit.DecinewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from DecinewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromDecinewtonsPerMillimeter(double decinewtonspermillimeter) => new ForcePerLength(decinewtonspermillimeter, ForcePerLengthUnit.DecinewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from KilogramsForcePerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromKilogramsForcePerCentimeter(double kilogramsforcepercentimeter) => new ForcePerLength(kilogramsforcepercentimeter, ForcePerLengthUnit.KilogramForcePerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from KilogramsForcePerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromKilogramsForcePerMeter(double kilogramsforcepermeter) => new ForcePerLength(kilogramsforcepermeter, ForcePerLengthUnit.KilogramForcePerMeter);

        /// <summary>
        ///     Get ForcePerLength from KilogramsForcePerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromKilogramsForcePerMillimeter(double kilogramsforcepermillimeter) => new ForcePerLength(kilogramsforcepermillimeter, ForcePerLengthUnit.KilogramForcePerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from KilonewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromKilonewtonsPerCentimeter(double kilonewtonspercentimeter) => new ForcePerLength(kilonewtonspercentimeter, ForcePerLengthUnit.KilonewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from KilonewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromKilonewtonsPerMeter(double kilonewtonspermeter) => new ForcePerLength(kilonewtonspermeter, ForcePerLengthUnit.KilonewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from KilonewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromKilonewtonsPerMillimeter(double kilonewtonspermillimeter) => new ForcePerLength(kilonewtonspermillimeter, ForcePerLengthUnit.KilonewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from KilopoundsForcePerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromKilopoundsForcePerFoot(double kilopoundsforceperfoot) => new ForcePerLength(kilopoundsforceperfoot, ForcePerLengthUnit.KilopoundForcePerFoot);

        /// <summary>
        ///     Get ForcePerLength from KilopoundsForcePerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromKilopoundsForcePerInch(double kilopoundsforceperinch) => new ForcePerLength(kilopoundsforceperinch, ForcePerLengthUnit.KilopoundForcePerInch);

        /// <summary>
        ///     Get ForcePerLength from MeganewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMeganewtonsPerCentimeter(double meganewtonspercentimeter) => new ForcePerLength(meganewtonspercentimeter, ForcePerLengthUnit.MeganewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from MeganewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMeganewtonsPerMeter(double meganewtonspermeter) => new ForcePerLength(meganewtonspermeter, ForcePerLengthUnit.MeganewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from MeganewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMeganewtonsPerMillimeter(double meganewtonspermillimeter) => new ForcePerLength(meganewtonspermillimeter, ForcePerLengthUnit.MeganewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from MicronewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMicronewtonsPerCentimeter(double micronewtonspercentimeter) => new ForcePerLength(micronewtonspercentimeter, ForcePerLengthUnit.MicronewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from MicronewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMicronewtonsPerMeter(double micronewtonspermeter) => new ForcePerLength(micronewtonspermeter, ForcePerLengthUnit.MicronewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from MicronewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMicronewtonsPerMillimeter(double micronewtonspermillimeter) => new ForcePerLength(micronewtonspermillimeter, ForcePerLengthUnit.MicronewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from MillinewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMillinewtonsPerCentimeter(double millinewtonspercentimeter) => new ForcePerLength(millinewtonspercentimeter, ForcePerLengthUnit.MillinewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from MillinewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMillinewtonsPerMeter(double millinewtonspermeter) => new ForcePerLength(millinewtonspermeter, ForcePerLengthUnit.MillinewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from MillinewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromMillinewtonsPerMillimeter(double millinewtonspermillimeter) => new ForcePerLength(millinewtonspermillimeter, ForcePerLengthUnit.MillinewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from NanonewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromNanonewtonsPerCentimeter(double nanonewtonspercentimeter) => new ForcePerLength(nanonewtonspercentimeter, ForcePerLengthUnit.NanonewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from NanonewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromNanonewtonsPerMeter(double nanonewtonspermeter) => new ForcePerLength(nanonewtonspermeter, ForcePerLengthUnit.NanonewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from NanonewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromNanonewtonsPerMillimeter(double nanonewtonspermillimeter) => new ForcePerLength(nanonewtonspermillimeter, ForcePerLengthUnit.NanonewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from NewtonsPerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromNewtonsPerCentimeter(double newtonspercentimeter) => new ForcePerLength(newtonspercentimeter, ForcePerLengthUnit.NewtonPerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from NewtonsPerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromNewtonsPerMeter(double newtonspermeter) => new ForcePerLength(newtonspermeter, ForcePerLengthUnit.NewtonPerMeter);

        /// <summary>
        ///     Get ForcePerLength from NewtonsPerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromNewtonsPerMillimeter(double newtonspermillimeter) => new ForcePerLength(newtonspermillimeter, ForcePerLengthUnit.NewtonPerMillimeter);

        /// <summary>
        ///     Get ForcePerLength from PoundsForcePerFoot.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromPoundsForcePerFoot(double poundsforceperfoot) => new ForcePerLength(poundsforceperfoot, ForcePerLengthUnit.PoundForcePerFoot);

        /// <summary>
        ///     Get ForcePerLength from PoundsForcePerInch.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromPoundsForcePerInch(double poundsforceperinch) => new ForcePerLength(poundsforceperinch, ForcePerLengthUnit.PoundForcePerInch);

        /// <summary>
        ///     Get ForcePerLength from PoundsForcePerYard.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromPoundsForcePerYard(double poundsforceperyard) => new ForcePerLength(poundsforceperyard, ForcePerLengthUnit.PoundForcePerYard);

        /// <summary>
        ///     Get ForcePerLength from TonnesForcePerCentimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromTonnesForcePerCentimeter(double tonnesforcepercentimeter) => new ForcePerLength(tonnesforcepercentimeter, ForcePerLengthUnit.TonneForcePerCentimeter);

        /// <summary>
        ///     Get ForcePerLength from TonnesForcePerMeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromTonnesForcePerMeter(double tonnesforcepermeter) => new ForcePerLength(tonnesforcepermeter, ForcePerLengthUnit.TonneForcePerMeter);

        /// <summary>
        ///     Get ForcePerLength from TonnesForcePerMillimeter.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ForcePerLength FromTonnesForcePerMillimeter(double tonnesforcepermillimeter) => new ForcePerLength(tonnesforcepermillimeter, ForcePerLengthUnit.TonneForcePerMillimeter);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ForcePerLengthUnit" /> to <see cref="ForcePerLength" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ForcePerLength unit value.</returns>
        public static ForcePerLength From(double value, ForcePerLengthUnit fromUnit)
        {
            return new ForcePerLength(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ForcePerLengthUnit unit) => GetValueAs(unit);        

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ForcePerLength ToUnit(ForcePerLengthUnit unit)
        {
                
            var convertedValue = GetValueAs(unit);
            return new ForcePerLength(convertedValue, unit);
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
                case ForcePerLengthUnit.CentinewtonPerCentimeter: return (_value*1e2) * 1e-2d;
                case ForcePerLengthUnit.CentinewtonPerMeter: return (_value) * 1e-2d;
                case ForcePerLengthUnit.CentinewtonPerMillimeter: return (_value*1e3) * 1e-2d;
                case ForcePerLengthUnit.DecanewtonPerCentimeter: return (_value*1e2) * 1e1d;
                case ForcePerLengthUnit.DecanewtonPerMeter: return (_value) * 1e1d;
                case ForcePerLengthUnit.DecanewtonPerMillimeter: return (_value*1e3) * 1e1d;
                case ForcePerLengthUnit.DecinewtonPerCentimeter: return (_value*1e2) * 1e-1d;
                case ForcePerLengthUnit.DecinewtonPerMeter: return (_value) * 1e-1d;
                case ForcePerLengthUnit.DecinewtonPerMillimeter: return (_value*1e3) * 1e-1d;
                case ForcePerLengthUnit.KilogramForcePerCentimeter: return _value*980.665002864;
                case ForcePerLengthUnit.KilogramForcePerMeter: return _value*9.80665002864;
                case ForcePerLengthUnit.KilogramForcePerMillimeter: return _value*9.80665002864e3;
                case ForcePerLengthUnit.KilonewtonPerCentimeter: return (_value*1e2) * 1e3d;
                case ForcePerLengthUnit.KilonewtonPerMeter: return (_value) * 1e3d;
                case ForcePerLengthUnit.KilonewtonPerMillimeter: return (_value*1e3) * 1e3d;
                case ForcePerLengthUnit.KilopoundForcePerFoot: return _value*14593.90292;
                case ForcePerLengthUnit.KilopoundForcePerInch: return _value*1.75126835e5;
                case ForcePerLengthUnit.MeganewtonPerCentimeter: return (_value*1e2) * 1e6d;
                case ForcePerLengthUnit.MeganewtonPerMeter: return (_value) * 1e6d;
                case ForcePerLengthUnit.MeganewtonPerMillimeter: return (_value*1e3) * 1e6d;
                case ForcePerLengthUnit.MicronewtonPerCentimeter: return (_value*1e2) * 1e-6d;
                case ForcePerLengthUnit.MicronewtonPerMeter: return (_value) * 1e-6d;
                case ForcePerLengthUnit.MicronewtonPerMillimeter: return (_value*1e3) * 1e-6d;
                case ForcePerLengthUnit.MillinewtonPerCentimeter: return (_value*1e2) * 1e-3d;
                case ForcePerLengthUnit.MillinewtonPerMeter: return (_value) * 1e-3d;
                case ForcePerLengthUnit.MillinewtonPerMillimeter: return (_value*1e3) * 1e-3d;
                case ForcePerLengthUnit.NanonewtonPerCentimeter: return (_value*1e2) * 1e-9d;
                case ForcePerLengthUnit.NanonewtonPerMeter: return (_value) * 1e-9d;
                case ForcePerLengthUnit.NanonewtonPerMillimeter: return (_value*1e3) * 1e-9d;
                case ForcePerLengthUnit.NewtonPerCentimeter: return _value*1e2;
                case ForcePerLengthUnit.NewtonPerMeter: return _value;
                case ForcePerLengthUnit.NewtonPerMillimeter: return _value*1e3;
                case ForcePerLengthUnit.PoundForcePerFoot: return _value*14.59390292;
                case ForcePerLengthUnit.PoundForcePerInch: return _value*1.75126835e2;
                case ForcePerLengthUnit.PoundForcePerYard: return _value*4.864634307;
                case ForcePerLengthUnit.TonneForcePerCentimeter: return _value*9.80665002864e5;
                case ForcePerLengthUnit.TonneForcePerMeter: return _value*9.80665002864e3;
                case ForcePerLengthUnit.TonneForcePerMillimeter: return _value*9.80665002864e6;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(ForcePerLengthUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ForcePerLengthUnit.CentinewtonPerCentimeter: return (baseUnitValue/1e2) / 1e-2d;
                case ForcePerLengthUnit.CentinewtonPerMeter: return (baseUnitValue) / 1e-2d;
                case ForcePerLengthUnit.CentinewtonPerMillimeter: return (baseUnitValue/1e3) / 1e-2d;
                case ForcePerLengthUnit.DecanewtonPerCentimeter: return (baseUnitValue/1e2) / 1e1d;
                case ForcePerLengthUnit.DecanewtonPerMeter: return (baseUnitValue) / 1e1d;
                case ForcePerLengthUnit.DecanewtonPerMillimeter: return (baseUnitValue/1e3) / 1e1d;
                case ForcePerLengthUnit.DecinewtonPerCentimeter: return (baseUnitValue/1e2) / 1e-1d;
                case ForcePerLengthUnit.DecinewtonPerMeter: return (baseUnitValue) / 1e-1d;
                case ForcePerLengthUnit.DecinewtonPerMillimeter: return (baseUnitValue/1e3) / 1e-1d;
                case ForcePerLengthUnit.KilogramForcePerCentimeter: return baseUnitValue/980.665002864;
                case ForcePerLengthUnit.KilogramForcePerMeter: return baseUnitValue/9.80665002864;
                case ForcePerLengthUnit.KilogramForcePerMillimeter: return baseUnitValue/9.80665002864e3;
                case ForcePerLengthUnit.KilonewtonPerCentimeter: return (baseUnitValue/1e2) / 1e3d;
                case ForcePerLengthUnit.KilonewtonPerMeter: return (baseUnitValue) / 1e3d;
                case ForcePerLengthUnit.KilonewtonPerMillimeter: return (baseUnitValue/1e3) / 1e3d;
                case ForcePerLengthUnit.KilopoundForcePerFoot: return baseUnitValue/14593.90292;
                case ForcePerLengthUnit.KilopoundForcePerInch: return baseUnitValue/1.75126835e5;
                case ForcePerLengthUnit.MeganewtonPerCentimeter: return (baseUnitValue/1e2) / 1e6d;
                case ForcePerLengthUnit.MeganewtonPerMeter: return (baseUnitValue) / 1e6d;
                case ForcePerLengthUnit.MeganewtonPerMillimeter: return (baseUnitValue/1e3) / 1e6d;
                case ForcePerLengthUnit.MicronewtonPerCentimeter: return (baseUnitValue/1e2) / 1e-6d;
                case ForcePerLengthUnit.MicronewtonPerMeter: return (baseUnitValue) / 1e-6d;
                case ForcePerLengthUnit.MicronewtonPerMillimeter: return (baseUnitValue/1e3) / 1e-6d;
                case ForcePerLengthUnit.MillinewtonPerCentimeter: return (baseUnitValue/1e2) / 1e-3d;
                case ForcePerLengthUnit.MillinewtonPerMeter: return (baseUnitValue) / 1e-3d;
                case ForcePerLengthUnit.MillinewtonPerMillimeter: return (baseUnitValue/1e3) / 1e-3d;
                case ForcePerLengthUnit.NanonewtonPerCentimeter: return (baseUnitValue/1e2) / 1e-9d;
                case ForcePerLengthUnit.NanonewtonPerMeter: return (baseUnitValue) / 1e-9d;
                case ForcePerLengthUnit.NanonewtonPerMillimeter: return (baseUnitValue/1e3) / 1e-9d;
                case ForcePerLengthUnit.NewtonPerCentimeter: return baseUnitValue/1e2;
                case ForcePerLengthUnit.NewtonPerMeter: return baseUnitValue;
                case ForcePerLengthUnit.NewtonPerMillimeter: return baseUnitValue/1e3;
                case ForcePerLengthUnit.PoundForcePerFoot: return baseUnitValue/14.59390292;
                case ForcePerLengthUnit.PoundForcePerInch: return baseUnitValue/1.75126835e2;
                case ForcePerLengthUnit.PoundForcePerYard: return baseUnitValue/4.864634307;
                case ForcePerLengthUnit.TonneForcePerCentimeter: return baseUnitValue/9.80665002864e5;
                case ForcePerLengthUnit.TonneForcePerMeter: return baseUnitValue/9.80665002864e3;
                case ForcePerLengthUnit.TonneForcePerMillimeter: return baseUnitValue/9.80665002864e6;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

