public interface IDocumentFactory
{
    IBankDocument CreateRIB();
    IBankDocument CreateAttestation();
}