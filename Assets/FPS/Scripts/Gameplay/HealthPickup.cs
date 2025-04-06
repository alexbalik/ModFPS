using Unity.FPS.Game;
using UnityEngine;

namespace Unity.FPS.Gameplay
{
    public class HealthPickup : Pickup
    {
        [Header("Parameters")] [Tooltip("Amount of health to heal on pickup")]
        public float HealAmount;

        protected override void OnPicked(PlayerCharacterController player)
        {
            Health playerHealth = player.GetComponent<Health>();
            if (playerHealth) //&& playerHealth.CanPickup())
            {
                //playerHealth.Heal(HealAmount);
                PlayPickupFeedback();
                Destroy(gameObject);
                //Note: At first you tried to use the "HandleDeath()" method directly, but HandleDeath() is
                //a private method inside the Health class. Then you made the HandleDeath() method public
                //which worked, but below is a safer way to access HandleDeath. The statement below accesses
                //HandleDeath through another already public method - TakeDamage() - that calls HandleDeath at the
                //end of its body
                playerHealth.TakeDamage(HealAmount, null);
            }
        }
    }
}