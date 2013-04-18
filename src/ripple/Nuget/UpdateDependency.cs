﻿using ripple.Model;

namespace ripple.Nuget
{
    public class UpdateDependency : INugetStep
    {
        private readonly Dependency _dependency;

        public UpdateDependency(Dependency dependency)
        {
            _dependency = dependency;
        }

        public void Execute(INugetStepRunner runner)
        {
            runner.UpdateDependency(_dependency);
        }

        protected bool Equals(UpdateDependency other)
        {
            return Equals(_dependency, other._dependency);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((UpdateDependency)obj);
        }

        public override int GetHashCode()
        {
            return (_dependency != null ? _dependency.GetHashCode() : 0);
        }
    }
}