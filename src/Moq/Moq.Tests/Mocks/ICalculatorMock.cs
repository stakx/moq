﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Stunts;
using System.Runtime.CompilerServices;
using Sample;
using System.Threading;
using Moq.Sdk;
using System.Diagnostics;

namespace Mocks
{
    [DebuggerDisplay("{DebuggerDisplay,nq}")]
    public partial class ICalculatorMock : ICalculator, IStunt, IMocked
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        readonly BehaviorPipeline pipeline = new BehaviorPipeline();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        [CompilerGenerated]
        ObservableCollection<IStuntBehavior> IStunt.Behaviors => pipeline.Behaviors;

        [CompilerGenerated]
        public int? this[string name] { get => pipeline.Execute<int?>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), name)); set => pipeline.Execute(new MethodInvocation(this, MethodBase.GetCurrentMethod(), name, value)); }

        [CompilerGenerated]
        public bool IsOn => pipeline.Execute<bool>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));

        [CompilerGenerated]
        public CalculatorMode Mode { get => pipeline.Execute<CalculatorMode>(new MethodInvocation(this, MethodBase.GetCurrentMethod())); set => pipeline.Execute(new MethodInvocation(this, MethodBase.GetCurrentMethod(), value)); }

        [CompilerGenerated]
        public ICalculatorMemory Memory => pipeline.Execute<ICalculatorMemory>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));

        [CompilerGenerated]
        public int Add(int x, int y) => pipeline.Execute<int>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), x, y));
        [CompilerGenerated]
        public int Add(int x, int y, int z) => pipeline.Execute<int>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), x, y, z));
        [CompilerGenerated]
        public void Clear(string name) => pipeline.Execute(new MethodInvocation(this, MethodBase.GetCurrentMethod(), name));
        [CompilerGenerated]
        public override bool Equals(object obj) => pipeline.Execute<bool>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), obj));
        [CompilerGenerated]
        public override int GetHashCode() => pipeline.Execute<int>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));
        [CompilerGenerated]
        public int? Recall(string name) => pipeline.Execute<int?>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), name));
        [CompilerGenerated]
        public void Store(string name, int value) => pipeline.Execute(new MethodInvocation(this, MethodBase.GetCurrentMethod(), name, value));
        [CompilerGenerated]
        public override string ToString() => pipeline.Execute<string>(new MethodInvocation(this, MethodBase.GetCurrentMethod()));

        [CompilerGenerated]
        public bool TryAdd(ref int x, ref int y, out int z)
        {
            z = default(int);
            IMethodReturn returns = pipeline.Execute(new MethodInvocation(this, MethodBase.GetCurrentMethod(), x, y, z));
            x = (int)returns.Outputs["x"];
            y = (int)returns.Outputs["y"];
            z = (int)returns.Outputs["z"];
            return (bool)returns.ReturnValue;
        }

        [CompilerGenerated]
        public void TurnOn() => pipeline.Execute(new MethodInvocation(this, MethodBase.GetCurrentMethod()));

        [CompilerGenerated]
        public event EventHandler TurnedOn { add => pipeline.Execute<EventHandler>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), value)); remove => pipeline.Execute<EventHandler>(new MethodInvocation(this, MethodBase.GetCurrentMethod(), value)); }

        #region IMocked
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IMock mock;

        [DebuggerDisplay("Invocations = {Invocations.Count}", Name = nameof(IMocked.Mock))]
        [DebuggerBrowsable(DebuggerBrowsableState.Collapsed)]
        [CompilerGenerated]
        IMock IMocked.Mock => LazyInitializer.EnsureInitialized(ref mock, () => new DefaultMock(this));
        #endregion

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        string DebuggerDisplay => ((IMocked)this).Mock.State.TryGetValue<string>("Name", out var name) ? name : GetType().Name;
    }
}