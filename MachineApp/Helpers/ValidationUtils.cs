
namespace MachineApp.Helpers
{
    public static class ValidationUtils
    {
        public static List<string> ValidateRequiredFields(params (string key, string value)[] fields)
        {
            var errors = new List<string>();

            foreach (var (k, v) in fields)
            {
                if (string.IsNullOrWhiteSpace(k))
                    errors.Add($"{v} is required!");
            }

            return errors;
        }
    }
}
