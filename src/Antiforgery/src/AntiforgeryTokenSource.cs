namespace Microsoft.AspNetCore.Antiforgery;
[Flags]
public enum AntiforgeryTokenSource
{
    Header = 1,
    FormBody = 2,
}
