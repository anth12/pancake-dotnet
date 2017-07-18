
namespace Pancake.Csv
{
    public interface IWriter<TType>
    {
        void WriteCell(TType value);
    }
}
