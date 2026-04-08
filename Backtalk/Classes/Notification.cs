using System.ComponentModel.DataAnnotations;

namespace Backtalk.Classes
{
    public enum NotificationType
    {
        POPUP_WARNING, //yellowish background
        POPUP_INFO, //white/grey background
        POPUP_ERROR, //red background
        POPUP_SUCCESS, //green/lime background
        INBOX_WARNING, // whiteish yellowish background - shows up in inbox not on screen
        INBOX_INFO, //greyish background - shows up in inbox not on screen
        INBOX_ERROR, //redish background - shows up in inbox not on screen
        INBOX_SUCCESS, //greenish background - shows up in inbox not on screen
        INBOX_IMPORTANT, //greyish background, but has exclamation mark - shows up in inbox not on screen
    }

    //Symbols are enclosed inside of a black bordered circle
    public enum NotificationSymbol
    {
        EXCLAMATION,
        QUESTION_MARK,
        FROWN,
        SMILE,
        CHECKMARK,
        INFO,
        SUS
    }

    public class Notification
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public NotificationType type { get; set; } = NotificationType.POPUP_INFO;
        public NotificationSymbol symbol { get; set; } = NotificationSymbol.INFO;
        public string message { get; set; } = "Info Notification";
        public DateTime expire_at_utc { get; set; } = DateTime.UtcNow.AddSeconds(3);
        public bool read { get; set; } = false;
    }
}
