using Backtalk.Classes;

namespace Backtalk.Services
{
    public interface INotificationService
    {
        public void CreatePopupNotification(Notification notification);
        public void DeletePopupNotification(Notification notification);
        public Task<IReadOnlyList<Notification>> GetPopupNotifications();
        public Task<bool> CreateInboxNotificationAsync(Notification notification);
        public Task<bool> DeleteInboxNotificationAsync(Notification notification);
        public Task<bool> MarkInboxNotificationReadAsync(Notification notification);
        public Task<IReadOnlyList<Notification>?> GetInboxNotificationsAsync();
    }
}
