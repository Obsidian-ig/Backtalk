using Backtalk.Classes;

namespace Backtalk.Services
{
    public interface INotificationService
    {
        public event EventHandler<IReadOnlyList<Notification>> PopupNotificationsUpdated;
        public event EventHandler<IReadOnlyList<Notification>> InboxNotificationsUpdated;
        public Task CreatePopupNotification(Notification notification);
        public Task DeletePopupNotification(Notification notification);
        public Task<IReadOnlyList<Notification>> GetPopupNotifications();
        public Task<bool> CreateInboxNotificationAsync(Notification notification);
        public Task<bool> DeleteInboxNotificationAsync(Notification notification);
        public Task<bool> MarkInboxNotificationReadAsync(Notification notification);
        public Task<IReadOnlyList<Notification>?> GetInboxNotificationsAsync();
    }
}
