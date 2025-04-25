using PainForGlory_Common.DTOs;

namespace PainForGlory_Common.Helpers
{
    public static class AccountHistoryFormatter
    {
        public static List<FormattedAccountHistory> BuildFormattedHistoryList(
            List<PreviousAccountInfo> historyList,
            string? currentUsername,
            string? currentEmail)
        {
            // Sort oldest to newest
            var ordered = historyList.OrderBy(h => h.ChangedAt).ToList();
            var entries = new List<(DateTime ChangedAt, string? OldUsername, string? OldEmail)>();

            foreach (var h in ordered)
            {
                entries.Add((h.ChangedAt, h.OldUsername, h.OldEmail));
            }

            // Add current as the last "new" state
            entries.Add((DateTime.UtcNow, currentUsername, currentEmail));

            var result = new List<FormattedAccountHistory>();

            for (int i = 0; i < entries.Count - 1; i++)
            {
                var old = entries[i];
                var @new = entries[i + 1];

                string text = $"Date: {old.ChangedAt.ToLocalTime():g}";

                if (old.OldUsername != null)
                    text += $" | Previous Username: {old.OldUsername} | New Username: {@new.OldUsername}";

                if (old.OldEmail != null)
                    text += $" | Previous Email: {old.OldEmail} | New Email: {@new.OldEmail}";

                result.Add(new FormattedAccountHistory
                {
                    ChangedAt = old.ChangedAt,
                    FormattedText = text
                });
            }

            // Reverse to show newest first
            return result.OrderByDescending(f => f.ChangedAt).ToList();
        }
    }
}
