﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of Force.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ForceTestsBase
    {
        protected abstract double DecanewtonsInOneNewton { get; }
        protected abstract double DyneInOneNewton { get; }
        protected abstract double KilogramsForceInOneNewton { get; }
        protected abstract double KilonewtonsInOneNewton { get; }
        protected abstract double KiloPondsInOneNewton { get; }
        protected abstract double MeganewtonsInOneNewton { get; }
        protected abstract double NewtonsInOneNewton { get; }
        protected abstract double PoundalsInOneNewton { get; }
        protected abstract double PoundsForceInOneNewton { get; }
        protected abstract double TonnesForceInOneNewton { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double DecanewtonsTolerance { get { return 1e-5; } }
        protected virtual double DyneTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForceTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsTolerance { get { return 1e-5; } }
        protected virtual double KiloPondsTolerance { get { return 1e-5; } }
        protected virtual double MeganewtonsTolerance { get { return 1e-5; } }
        protected virtual double NewtonsTolerance { get { return 1e-5; } }
        protected virtual double PoundalsTolerance { get { return 1e-5; } }
        protected virtual double PoundsForceTolerance { get { return 1e-5; } }
        protected virtual double TonnesForceTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void NewtonToForceUnits()
        {
            Force newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, newton.Decanewtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(DyneInOneNewton, newton.Dyne, DyneTolerance);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, newton.KilogramsForce, KilogramsForceTolerance);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, newton.Kilonewtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, newton.KiloPonds, KiloPondsTolerance);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, newton.Meganewtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(NewtonsInOneNewton, newton.Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(PoundalsInOneNewton, newton.Poundals, PoundalsTolerance);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, newton.PoundsForce, PoundsForceTolerance);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, newton.TonnesForce, TonnesForceTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Decanewton).Decanewtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Dyn).Dyne, DyneTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.KilogramForce).KilogramsForce, KilogramsForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Kilonewton).Kilonewtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.KiloPond).KiloPonds, KiloPondsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Meganewton).Meganewtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Newton).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.Poundal).Poundals, PoundalsTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.PoundForce).PoundsForce, PoundsForceTolerance);
            AssertEx.EqualTolerance(1, Force.From(1, ForceUnit.TonneForce).TonnesForce, TonnesForceTolerance);
        }

        [Fact]
        public void As()
        {
            var newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(DecanewtonsInOneNewton, newton.As(ForceUnit.Decanewton), DecanewtonsTolerance);
            AssertEx.EqualTolerance(DyneInOneNewton, newton.As(ForceUnit.Dyn), DyneTolerance);
            AssertEx.EqualTolerance(KilogramsForceInOneNewton, newton.As(ForceUnit.KilogramForce), KilogramsForceTolerance);
            AssertEx.EqualTolerance(KilonewtonsInOneNewton, newton.As(ForceUnit.Kilonewton), KilonewtonsTolerance);
            AssertEx.EqualTolerance(KiloPondsInOneNewton, newton.As(ForceUnit.KiloPond), KiloPondsTolerance);
            AssertEx.EqualTolerance(MeganewtonsInOneNewton, newton.As(ForceUnit.Meganewton), MeganewtonsTolerance);
            AssertEx.EqualTolerance(NewtonsInOneNewton, newton.As(ForceUnit.Newton), NewtonsTolerance);
            AssertEx.EqualTolerance(PoundalsInOneNewton, newton.As(ForceUnit.Poundal), PoundalsTolerance);
            AssertEx.EqualTolerance(PoundsForceInOneNewton, newton.As(ForceUnit.PoundForce), PoundsForceTolerance);
            AssertEx.EqualTolerance(TonnesForceInOneNewton, newton.As(ForceUnit.TonneForce), TonnesForceTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Force newton = Force.FromNewtons(1);
            AssertEx.EqualTolerance(1, Force.FromDecanewtons(newton.Decanewtons).Newtons, DecanewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromDyne(newton.Dyne).Newtons, DyneTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilogramsForce(newton.KilogramsForce).Newtons, KilogramsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromKilonewtons(newton.Kilonewtons).Newtons, KilonewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromKiloPonds(newton.KiloPonds).Newtons, KiloPondsTolerance);
            AssertEx.EqualTolerance(1, Force.FromMeganewtons(newton.Meganewtons).Newtons, MeganewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromNewtons(newton.Newtons).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(1, Force.FromPoundals(newton.Poundals).Newtons, PoundalsTolerance);
            AssertEx.EqualTolerance(1, Force.FromPoundsForce(newton.PoundsForce).Newtons, PoundsForceTolerance);
            AssertEx.EqualTolerance(1, Force.FromTonnesForce(newton.TonnesForce).Newtons, TonnesForceTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Force v = Force.FromNewtons(1);
            AssertEx.EqualTolerance(-1, -v.Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (Force.FromNewtons(3)-v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, (Force.FromNewtons(10)/5).Newtons, NewtonsTolerance);
            AssertEx.EqualTolerance(2, Force.FromNewtons(10)/Force.FromNewtons(5), NewtonsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Force oneNewton = Force.FromNewtons(1);
            Force twoNewtons = Force.FromNewtons(2);

            Assert.True(oneNewton < twoNewtons);
            Assert.True(oneNewton <= twoNewtons);
            Assert.True(twoNewtons > oneNewton);
            Assert.True(twoNewtons >= oneNewton);

            Assert.False(oneNewton > twoNewtons);
            Assert.False(oneNewton >= twoNewtons);
            Assert.False(twoNewtons < oneNewton);
            Assert.False(twoNewtons <= oneNewton);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Equal(0, newton.CompareTo(newton));
            Assert.True(newton.CompareTo(Force.Zero) > 0);
            Assert.True(Force.Zero.CompareTo(newton) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Throws<ArgumentException>(() => newton.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Force newton = Force.FromNewtons(1);
            Assert.Throws<ArgumentNullException>(() => newton.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Force a = Force.FromNewtons(1);
            Force b = Force.FromNewtons(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            Force v = Force.FromNewtons(1);
            Assert.True(v.Equals(Force.FromNewtons(1), Force.FromNewtons(NewtonsTolerance)));
            Assert.False(v.Equals(Force.Zero, Force.FromNewtons(NewtonsTolerance)));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Force newton = Force.FromNewtons(1);
            Assert.False(newton.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Force newton = Force.FromNewtons(1);
            Assert.False(newton.Equals(null));
        }
    }
}
