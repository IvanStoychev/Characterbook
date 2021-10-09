namespace Frontend.Models
{
    /// <summary>
    /// All possible sizes a character can be.
    /// </summary>
    public enum CharacterSize
    {
        /// <summary>
        /// +16 to "hide" checks.
        /// -16 to "grapple" checks.
        /// -16 to "break open door" checks.
        /// x0.125 carry weight multiplier.
        /// 0.5 ft. space occupied in combat.
        /// 0.0 ft. natural (horizontal) reach.
        /// 0.5 ft. vertical reach.
        /// </summary>
        Fine,

        /// <summary>
        /// +12 to "hide" checks.
        /// -12 to "grapple" checks.
        /// -12 to "break open door" checks.
        /// x0.25 carry weight multiplier.
        /// 1 ft. space occupied in combat.
        /// 0 ft. natural (horizontal) reach.
        /// 1 ft. vertical reach.
        /// </summary>
        Diminutive,

        /// <summary>
        /// +8 to "hide" checks.
        /// -8 to "grapple" checks.
        /// -8 to "break open door" checks.
        /// x0.5 carry weight multiplier.
        /// 2 - 0.5 ft. space occupied in combat.
        /// 0 ft. natural (horizontal) reach.
        /// 2 ft. vertical reach.
        /// </summary>
        Tiny,

        /// <summary>
        /// +4 to "hide" checks.
        /// -4 to "grapple" checks.
        /// -4 to "break open door" checks.
        /// x0.75 carry weight multiplier.
        /// 5 ft. space occupied in combat.
        /// 5 ft. natural (horizontal) reach.
        /// 4 ft. vertical reach.
        /// </summary>
        Small,

        /// <summary>
        /// 5 ft. space occupied in combat.
        /// 5 ft. natural (horizontal) reach.
        /// 8 ft. vertical reach.
        /// </summary>
        Medium,

        /// <summary>
        /// -4 to "hide" checks.
        /// +4 to "grapple" checks.
        /// +4 to "break open door" checks.
        /// x2 carry weight multiplier.
        /// 10 ft. space occupied in combat.
        ///  5 ft. natural (horizontal) reach.
        /// 16 ft. vertical reach.
        /// </summary>
        Large_Long,

        /// <summary>
        /// -4 to "hide" checks.
        /// +4 to "grapple" checks.
        /// +4 to "break open door" checks.
        /// x2 carry weight multiplier.
        /// 10 ft. space occupied in combat.
        /// 10 ft. natural (horizontal) reach.
        /// 16 ft. vertical reach.
        /// </summary>
        Large_Tall,

        /// <summary>
        /// -8 to "hide" checks.
        /// +8 to "grapple" checks.
        /// +8 to "break open door" checks.
        /// x4 carry weight multiplier.
        /// 15 ft. space occupied in combat.
        /// 10 ft. natural (horizontal) reach.
        /// 32 ft. vertical reach.
        /// </summary>
        Huge_Long,

        /// <summary>
        /// -8 to "hide" checks.
        /// +8 to "grapple" checks.
        /// +8 to "break open door" checks.
        /// x4 carry weight multiplier.
        /// 15 ft. space occupied in combat.
        /// 15 ft. natural (horizontal) reach.
        /// 32 ft. vertical reach.
        /// </summary>
        Huge_Tall,

        /// <summary>
        /// -12 to "hide" checks.
        /// +12 to "grapple" checks.
        /// +12 to "break open door" checks.
        /// x8 carry weight multiplier.
        /// 20 ft. space occupied in combat.
        /// 15 ft. natural (horizontal) reach.
        /// 64 ft. vertical reach.
        /// </summary>
        Gargantuan_Long,

        /// <summary>
        /// -12 to "hide" checks.
        /// +12 to "grapple" checks.
        /// +12 to "break open door" checks.
        /// x8 carry weight multiplier.
        /// 20 ft. space occupied in combat.
        /// 20 ft. natural (horizontal) reach.
        /// 64 ft. vertical reach.
        /// </summary>
        Gargantuan_Tall,

        /// <summary>
        /// -16 to "hide" checks.
        /// +16 to "grapple" checks.
        /// +16 to "break open door" checks.
        /// x16 carry weight multiplier.
        /// 30 ft. space occupied in combat.
        /// 30 ft. natural (horizontal) reach.
        /// 128 ft. vertical reach.
        /// </summary>
        Colossal_Long,

        /// <summary>
        /// -16 to "hide" checks.
        /// +16 to "grapple" checks.
        /// +16 to "break open door" checks.
        /// x16 carry weight multiplier.
        /// 30 ft. space occupied in combat.
        /// 30 ft. natural (horizontal) reach.
        /// 128 ft. vertical reach.
        /// </summary>
        Colossal_Tall
    }
    /// <summary>
    /// All astral signs the player characters can be born under.
    /// </summary>
    public enum BirthSigns
    {
        /// <summary>
        /// +1 to "Strength" ability.
        /// </summary>
        Bear,

        /// <summary>
        /// +1 to "Charisma" ability.
        /// </summary>
        Fire,

        /// <summary>
        /// +1 to "Dexterity" ability.
        /// </summary>
        Lightning,

        /// <summary>
        /// +1 to "Courage" score.
        /// </summary>
        Lion,

        /// <summary>
        /// +1 to "Constitution" ability.
        /// </summary>
        Ocean,

        /// <summary>
        /// +1 to "Intelligence" ability.
        /// </summary>
        SettingSun,

        /// <summary>
        /// +1 to all "Reflex" saves.
        /// </summary>
        ShootingStar,

        /// <summary>
        /// +2 to "hide skill" checks.
        /// </summary>
        TheTwoMoons,

        /// <summary>
        /// +1 to all "Fortitude" saves.
        /// </summary>
        Tree,

        /// <summary>
        /// +1 to "Wisdom" ability.
        /// </summary>
        Wind,

        /// <summary>
        /// +1 to all "Will" saves.
        /// </summary>
        Wolf,

        /// <summary>
        /// +1 to "Intelligence" score.
        /// </summary>
        Wyrm
    }
}