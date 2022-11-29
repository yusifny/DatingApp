using System;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Helpers;

namespace API.Interfaces
{
    public interface IMessageRepository
    {
        void AddMessage(Message mesaage);
        void DeleteMessage(Message mesaage);
        Task<Message> GetMessage(int id);
        Task<PagedList<MessageDto>> GetMessagesForUser(int id);
        Task<IEquatable<MessageDto>> GetMessagesThread(int currentUserId, int recipientId);
        Task<bool> SaveAllAsync(); 
    }
}