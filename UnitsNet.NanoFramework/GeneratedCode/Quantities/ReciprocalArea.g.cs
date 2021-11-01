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
    ///     Reciprocal area (Inverse-square) quantity is used to specify a physical quantity inversely proportional to the square of the distance.
    /// </summary>
    /// <remarks>
    ///     https://en.wikipedia.org/wiki/Inverse-square_law
    /// </remarks>
    public struct  ReciprocalArea
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly ReciprocalAreaUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public ReciprocalAreaUnit Unit => _unit;
        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public ReciprocalArea(double value, ReciprocalAreaUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static ReciprocalAreaUnit ConversionBaseUnit { get; } = ReciprocalAreaUnit.InverseSquareMeter;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static ReciprocalArea MaxValue { get; } = new ReciprocalArea(double.MaxValue, ConversionBaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static ReciprocalArea MinValue { get; } = new ReciprocalArea(double.MinValue, ConversionBaseUnit);
        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static ReciprocalArea Zero { get; } = new ReciprocalArea(0, ConversionBaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareCentimeters.
        /// </summary>
        public double InverseSquareCentimeters => As(ReciprocalAreaUnit.InverseSquareCentimeter);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareDecimeters.
        /// </summary>
        public double InverseSquareDecimeters => As(ReciprocalAreaUnit.InverseSquareDecimeter);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareFeet.
        /// </summary>
        public double InverseSquareFeet => As(ReciprocalAreaUnit.InverseSquareFoot);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareInches.
        /// </summary>
        public double InverseSquareInches => As(ReciprocalAreaUnit.InverseSquareInch);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareKilometers.
        /// </summary>
        public double InverseSquareKilometers => As(ReciprocalAreaUnit.InverseSquareKilometer);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareMeters.
        /// </summary>
        public double InverseSquareMeters => As(ReciprocalAreaUnit.InverseSquareMeter);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareMicrometers.
        /// </summary>
        public double InverseSquareMicrometers => As(ReciprocalAreaUnit.InverseSquareMicrometer);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareMiles.
        /// </summary>
        public double InverseSquareMiles => As(ReciprocalAreaUnit.InverseSquareMile);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareMillimeters.
        /// </summary>
        public double InverseSquareMillimeters => As(ReciprocalAreaUnit.InverseSquareMillimeter);

        /// <summary>
        ///     Get ReciprocalArea in InverseSquareYards.
        /// </summary>
        public double InverseSquareYards => As(ReciprocalAreaUnit.InverseSquareYard);

        /// <summary>
        ///     Get ReciprocalArea in InverseUsSurveySquareFeet.
        /// </summary>
        public double InverseUsSurveySquareFeet => As(ReciprocalAreaUnit.InverseUsSurveySquareFoot);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareCentimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareCentimeters(double inversesquarecentimeters) => new ReciprocalArea(inversesquarecentimeters, ReciprocalAreaUnit.InverseSquareCentimeter);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareDecimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareDecimeters(double inversesquaredecimeters) => new ReciprocalArea(inversesquaredecimeters, ReciprocalAreaUnit.InverseSquareDecimeter);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareFeet(double inversesquarefeet) => new ReciprocalArea(inversesquarefeet, ReciprocalAreaUnit.InverseSquareFoot);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareInches.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareInches(double inversesquareinches) => new ReciprocalArea(inversesquareinches, ReciprocalAreaUnit.InverseSquareInch);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareKilometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareKilometers(double inversesquarekilometers) => new ReciprocalArea(inversesquarekilometers, ReciprocalAreaUnit.InverseSquareKilometer);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareMeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareMeters(double inversesquaremeters) => new ReciprocalArea(inversesquaremeters, ReciprocalAreaUnit.InverseSquareMeter);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareMicrometers.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareMicrometers(double inversesquaremicrometers) => new ReciprocalArea(inversesquaremicrometers, ReciprocalAreaUnit.InverseSquareMicrometer);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareMiles.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareMiles(double inversesquaremiles) => new ReciprocalArea(inversesquaremiles, ReciprocalAreaUnit.InverseSquareMile);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareMillimeters.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareMillimeters(double inversesquaremillimeters) => new ReciprocalArea(inversesquaremillimeters, ReciprocalAreaUnit.InverseSquareMillimeter);

        /// <summary>
        ///     Get ReciprocalArea from InverseSquareYards.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseSquareYards(double inversesquareyards) => new ReciprocalArea(inversesquareyards, ReciprocalAreaUnit.InverseSquareYard);

        /// <summary>
        ///     Get ReciprocalArea from InverseUsSurveySquareFeet.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static ReciprocalArea FromInverseUsSurveySquareFeet(double inverseussurveysquarefeet) => new ReciprocalArea(inverseussurveysquarefeet, ReciprocalAreaUnit.InverseUsSurveySquareFoot);


        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="ReciprocalAreaUnit" /> to <see cref="ReciprocalArea" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>ReciprocalArea unit value.</returns>
        public static ReciprocalArea From(double value, ReciprocalAreaUnit fromUnit)
        {
            return new ReciprocalArea(value, fromUnit);
        }

        #endregion

        #region Conversion Methods

        /// <summary>
        ///     Convert to the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>Value converted to the specified unit.</returns>
        public double As(ReciprocalAreaUnit unit) => GetValueAs(unit);

        /// <summary>
        ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
        /// </summary>
        /// <returns>A Duration with the specified unit.</returns>
        public ReciprocalArea ToUnit(ReciprocalAreaUnit unit)
        {
            var convertedValue = GetValueAs(unit);
            return new ReciprocalArea(convertedValue, unit);
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
                case ReciprocalAreaUnit.InverseSquareCentimeter: return _value/1e-4;
                case ReciprocalAreaUnit.InverseSquareDecimeter: return _value/1e-2;
                case ReciprocalAreaUnit.InverseSquareFoot: return _value/0.092903;
                case ReciprocalAreaUnit.InverseSquareInch: return _value/0.00064516;
                case ReciprocalAreaUnit.InverseSquareKilometer: return _value/1e6;
                case ReciprocalAreaUnit.InverseSquareMeter: return _value;
                case ReciprocalAreaUnit.InverseSquareMicrometer: return _value/1e-12;
                case ReciprocalAreaUnit.InverseSquareMile: return _value/2.59e6;
                case ReciprocalAreaUnit.InverseSquareMillimeter: return _value/1e-6;
                case ReciprocalAreaUnit.InverseSquareYard: return _value/0.836127;
                case ReciprocalAreaUnit.InverseUsSurveySquareFoot: return _value/0.09290341161;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to base units.");
            }
        }

        private double GetValueAs(ReciprocalAreaUnit unit)
        {
            if(Unit == unit)
                return _value;

            var baseUnitValue = GetValueInBaseUnit();

            switch(unit)
            {
                case ReciprocalAreaUnit.InverseSquareCentimeter: return baseUnitValue*1e-4;
                case ReciprocalAreaUnit.InverseSquareDecimeter: return baseUnitValue*1e-2;
                case ReciprocalAreaUnit.InverseSquareFoot: return baseUnitValue*0.092903;
                case ReciprocalAreaUnit.InverseSquareInch: return baseUnitValue*0.00064516;
                case ReciprocalAreaUnit.InverseSquareKilometer: return baseUnitValue*1e6;
                case ReciprocalAreaUnit.InverseSquareMeter: return baseUnitValue;
                case ReciprocalAreaUnit.InverseSquareMicrometer: return baseUnitValue*1e-12;
                case ReciprocalAreaUnit.InverseSquareMile: return baseUnitValue*2.59e6;
                case ReciprocalAreaUnit.InverseSquareMillimeter: return baseUnitValue*1e-6;
                case ReciprocalAreaUnit.InverseSquareYard: return baseUnitValue*0.836127;
                case ReciprocalAreaUnit.InverseUsSurveySquareFoot: return baseUnitValue*0.09290341161;
                default:
                    throw new NotImplementedException($"Can not convert {Unit} to {unit}.");
            }
        }

        #endregion

    }
}

