namespace BestLibraryManagement.ViewModels{
    public class LibraryBranchesViewModel{
        public int LibraryBranchId { get; set; }
        public required string LibraryBranchName { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
    }
}