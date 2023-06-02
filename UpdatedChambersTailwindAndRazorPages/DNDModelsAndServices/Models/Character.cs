using UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models;
using static UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models.CharacterClassSelection;

namespace UpdatedChambersTailwindAndRazorPages.DNDModelsAndServices.Models
{
    public class Character
    {
        public ClassSelection DndClass { get; set; }
        public string Species { get; set; } 
        public int HitPoints { get; set; }
        public int Level { get; set; } = 1;
        public string Name { get; set; }
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Strength { get; set; }
        public int Wisdom { get; set; }
        public int Speed { get; set; } = 30;
		public bool ChaSavePoficiency { get; set; } = false;
		public bool ConSaveProficiency { get; set; } = false;
        public bool DexSaveProficiency { get; set; } = false;
        public bool IntSaveProficiency { get; set; } = false;
        public bool StrSaveProficiency { get; set; } = false;
        public bool WisSaveProficiency { get; set; } = false;
        public int ArmorClass { get; set; }
        public string? Subclass { get; set; } = null;
        public bool SteathDisadvantage { get; set; } = false;
        public int? IntSpellAttackBonus { get; set; } = null;
        public int? WisSpellAttackBonus { get; set; } = null;
        public int? ChaSpellAttackBonus { get; set; } = null;
        public int StrengthAttackBonus { get; set; }
        public int DexterityAttackBonus { get; set; }
        public int ProficiencyBonus { get; set; } = 2;
        public int? ChaSpellSaveDC { get; set; } = null;
		public int? IntSpellSaveDC { get; set; } = null;
		public int? WisSpellSaveDC { get; set; } = null;
		public int DexterityWeaponDamageBonus { get; set; }
        public int StrengthWeaponDamageBonus { get; set; }
        public int CharismaModifier { get; set; }
        public int ConstitutionModifier { get; set; }
        public int DexterityModifier { get; set; }
        public int IntelligenceModifier { get; set; }
        public int StrengthModifier { get; set; }
        public int WisdomModifier { get; set; }
        public int CharismaSavingThrow { get; set; }
        public int ConstitutionSavingThrow { get; set; }
        public int DexteritySavingThrow { get; set; }
        public int IntelligenceSavingThrow { get; set; }
        public int StrengthSavingThrow { get; set; }
        public int WisdomSavingThrow { get; set; }
        public bool FeyTouchedFeat { get; set; } = false;
		public bool PiercerFeat { get; set; } = false;
        public bool SlasherFeat { get; set; } = false;
        public bool CrusherFeat { get; set; } = false;
		public bool AthleticsProf { get; set; } = false;
        public bool AthleticsExpertise { get; set; } = false;
        public bool AcrobaticsProf { get; set; } = false;
        public bool AcrobaticsExpertise { get; set; } = false;
		public bool SleightofHandProf { get; set; } = false;
		public bool SleightofHandExpertise { get; set; } = false;
		public bool StealthProf { get; set; } = false;
		public bool StealthExpertise { get; set; } = false;
		public bool ArcanaProf { get; set; } = false;
        public bool ArcanaExpertise { get; set; } = false;
		public bool HistoryProf { get; set; } = false;
		public bool HistoryExpertise { get; set; } = false;
		public bool InvestigationProf { get; set; } = false;
		public bool InvestigationExpertise { get; set; } = false;
		public bool NatureProf { get; set; } = false;
		public bool NatureExpertise { get; set; } = false;
		public bool ReligionProf { get; set; } = false;
        public bool ReligionExpertise { get; set; } = false;
        public bool AnimalHandlingProf { get; set; } = false;
		public bool AnimalHandlingExpertise { get; set; } = false;
		public bool InsightProf { get; set; } = false;
		public bool InnsightExpertise { get; set; } = false;
		public bool MedicineProf { get; set; } = false;
		public bool MedicineExpertise { get; set; } = false;
		public bool PerceptionProf { get; set; } = false;
		public bool PerceptionExpertise { get; set; } = false;
		public bool SurvivalProf { get; set; } = false;
		public bool SurvivalExpertise { get; set; } = false;
		public bool DeceptionProf { get; set; } = false;
		public bool DeceptionExpertise { get; set; } = false;
        public bool IntimidationProf { get; set; } = false;
        public bool IntimidationExpertise { get; set; } = false;
        public bool PerformanceProf { get; set; } = false;
        public bool PerformanceExpertise { get; set; } = false;
		public bool PersuasionProf { get; set; } = false;
		public bool PersuasionExpertise { get; set; } = false;
		public bool ThievesToolsProf { get; set; } = false;
        public bool ThievesToolsExpertise { get; set; } = false;
        

    }
}
