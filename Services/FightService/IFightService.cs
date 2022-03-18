using DOTNET_RPG.Dtos.Fight;
using DOTNET_RPG.Models;

namespace DOTNET_RPG.Services.FightService
{
    public interface IFightService
    {
        Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto weaponAttack);
        Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto skillAttack);
        Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto fightRequest);

        Task<ServiceResponse<List<HighscoreDto>>> GetHighscore();
    }
}