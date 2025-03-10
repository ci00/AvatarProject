using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
    /// <summary>
    /// Multiplexed version of <see cref="IPokeStateDataProvider"/> that allows for multiple targets to be tracked with their own bindable poke state data.
    /// </summary>
    [MovedFrom("UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.State")]
    public interface IMultiPokeStateDataProvider
    {
        /// <summary>
        /// Return the bindable variable holding poke state data associated to the parameterized target transform.
        /// </summary>
        /// <param name="target">Target transform to track.</param>
        /// <returns>Bindable variable holding poke state data associated to the parameterized target transform.</returns>
        IReadOnlyBindableVariable<PokeStateData> GetPokeStateDataForTarget(Transform target);
    }
}
