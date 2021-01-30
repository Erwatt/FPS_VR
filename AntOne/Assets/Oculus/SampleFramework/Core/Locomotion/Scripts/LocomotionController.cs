/************************************************************************************

See SampleFramework license.txt for license terms.  Unless required by applicable law 
or agreed to in writing, the sample code is provided “AS IS” WITHOUT WARRANTIES OR 
CONDITIONS OF ANY KIND, either express or implied.  See the license for specific 
language governing permissions and limitations under the license.

************************************************************************************/

using System;
using UnityEngine;
using System.Collections;
using JetBrains.Annotations;
using UnityEngine.Assertions;
#if UNITY_EDITOR
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

#endif

/// <summary>
/// Simply aggregates accessors.
/// </summary>
public class LocomotionController : MonoBehaviour
{
    public OVRCameraRig CameraRig;
    //public CharacterController CharacterController;
    public CapsuleCollider CharacterController;
	//public OVRPlayerController PlayerController;
	public SimpleCapsuleWithStickMovement PlayerController;

    public XRController rightTeleportRay;
    public InputHelpers.Button teleportActivationButton;
    public float activationThreshold = 0.1f;

    public bool enableRightTeleport { get; set; } = true;
    
    private void Update()
    {
        if (rightTeleportRay)
        {
            rightTeleportRay.gameObject.SetActive(enableRightTeleport && CheckIfActivated(rightTeleportRay));
        }
    }

    public bool CheckIfActivated(XRController controller)
    {
        InputHelpers.IsPressed(controller.inputDevice, teleportActivationButton, out bool isActivated);
        return isActivated;
    }
}
