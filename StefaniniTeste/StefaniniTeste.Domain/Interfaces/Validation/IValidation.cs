using StefaniniTeste.Domain.Validation;

namespace StefaniniTeste.Domain.Interfaces.Validation
{
    public interface IValidation<in TEntity>
    {
        ValidationResult Valid(TEntity entity);
    }
}
