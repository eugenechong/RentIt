﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18033
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentIt.Team01Rentit {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/RentItServer.SMU")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsAdminField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private RentIt.Team01Rentit.Rental[] RentalsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsAdmin {
            get {
                return this.IsAdminField;
            }
            set {
                if ((this.IsAdminField.Equals(value) != true)) {
                    this.IsAdminField = value;
                    this.RaisePropertyChanged("IsAdmin");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public RentIt.Team01Rentit.Rental[] Rentals {
            get {
                return this.RentalsField;
            }
            set {
                if ((object.ReferenceEquals(this.RentalsField, value) != true)) {
                    this.RentalsField = value;
                    this.RaisePropertyChanged("Rentals");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Rental", Namespace="http://schemas.datacontract.org/2004/07/RentItServer.SMU")]
    [System.SerializableAttribute()]
    public partial class Rental : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> BookIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MediaTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> BookId {
            get {
                return this.BookIdField;
            }
            set {
                if ((this.BookIdField.Equals(value) != true)) {
                    this.BookIdField = value;
                    this.RaisePropertyChanged("BookId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int MediaType {
            get {
                return this.MediaTypeField;
            }
            set {
                if ((this.MediaTypeField.Equals(value) != true)) {
                    this.MediaTypeField = value;
                    this.RaisePropertyChanged("MediaType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Book", Namespace="http://schemas.datacontract.org/2004/07/RentItServer.SMU")]
    [System.SerializableAttribute()]
    public partial class Book : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AuthorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateAddedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DescriptionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GenreField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasAudioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool HasPdfField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int HitField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NarratorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TitleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Author {
            get {
                return this.AuthorField;
            }
            set {
                if ((object.ReferenceEquals(this.AuthorField, value) != true)) {
                    this.AuthorField = value;
                    this.RaisePropertyChanged("Author");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateAdded {
            get {
                return this.DateAddedField;
            }
            set {
                if ((this.DateAddedField.Equals(value) != true)) {
                    this.DateAddedField = value;
                    this.RaisePropertyChanged("DateAdded");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Genre {
            get {
                return this.GenreField;
            }
            set {
                if ((object.ReferenceEquals(this.GenreField, value) != true)) {
                    this.GenreField = value;
                    this.RaisePropertyChanged("Genre");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasAudio {
            get {
                return this.HasAudioField;
            }
            set {
                if ((this.HasAudioField.Equals(value) != true)) {
                    this.HasAudioField = value;
                    this.RaisePropertyChanged("HasAudio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool HasPdf {
            get {
                return this.HasPdfField;
            }
            set {
                if ((this.HasPdfField.Equals(value) != true)) {
                    this.HasPdfField = value;
                    this.RaisePropertyChanged("HasPdf");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Hit {
            get {
                return this.HitField;
            }
            set {
                if ((this.HitField.Equals(value) != true)) {
                    this.HitField = value;
                    this.RaisePropertyChanged("Hit");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Narrator {
            get {
                return this.NarratorField;
            }
            set {
                if ((object.ReferenceEquals(this.NarratorField, value) != true)) {
                    this.NarratorField = value;
                    this.RaisePropertyChanged("Narrator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Team01Rentit.ISMURentItService")]
    public interface ISMURentItService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/SignUp", ReplyAction="http://tempuri.org/ISMURentItService/SignUpResponse")]
        int SignUp(string email, string name, string password, bool isAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/LogIn", ReplyAction="http://tempuri.org/ISMURentItService/LogInResponse")]
        int LogIn(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetUserInfo", ReplyAction="http://tempuri.org/ISMURentItService/GetUserInfoResponse")]
        RentIt.Team01Rentit.User GetUserInfo(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/UpdateUserInfo", ReplyAction="http://tempuri.org/ISMURentItService/UpdateUserInfoResponse")]
        RentIt.Team01Rentit.User UpdateUserInfo(int userId, string email, string username, string password, System.Nullable<bool> isAdmin);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/DeleteAccount", ReplyAction="http://tempuri.org/ISMURentItService/DeleteAccountResponse")]
        void DeleteAccount(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetAllBooks", ReplyAction="http://tempuri.org/ISMURentItService/GetAllBooksResponse")]
        RentIt.Team01Rentit.Book[] GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetPopularBooks", ReplyAction="http://tempuri.org/ISMURentItService/GetPopularBooksResponse")]
        RentIt.Team01Rentit.Book[] GetPopularBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetNewBooks", ReplyAction="http://tempuri.org/ISMURentItService/GetNewBooksResponse")]
        RentIt.Team01Rentit.Book[] GetNewBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/SearchBooks", ReplyAction="http://tempuri.org/ISMURentItService/SearchBooksResponse")]
        RentIt.Team01Rentit.Book[] SearchBooks(string searchString);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetBooksByGenre", ReplyAction="http://tempuri.org/ISMURentItService/GetBooksByGenreResponse")]
        RentIt.Team01Rentit.Book[] GetBooksByGenre(string genre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetBookInfo", ReplyAction="http://tempuri.org/ISMURentItService/GetBookInfoResponse")]
        RentIt.Team01Rentit.Book GetBookInfo(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/HasRental", ReplyAction="http://tempuri.org/ISMURentItService/HasRentalResponse")]
        int HasRental(int userId, int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetRental", ReplyAction="http://tempuri.org/ISMURentItService/GetRentalResponse")]
        RentIt.Team01Rentit.Rental[] GetRental(int userId, int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/RentBook", ReplyAction="http://tempuri.org/ISMURentItService/RentBookResponse")]
        int RentBook(int userId, int bookId, int mediaType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/DownloadPdf", ReplyAction="http://tempuri.org/ISMURentItService/DownloadPdfResponse")]
        System.IO.MemoryStream DownloadPdf(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/DownloadAudio", ReplyAction="http://tempuri.org/ISMURentItService/DownloadAudioResponse")]
        System.IO.MemoryStream DownloadAudio(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/DeleteBook", ReplyAction="http://tempuri.org/ISMURentItService/DeleteBookResponse")]
        void DeleteBook(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/UploadBook", ReplyAction="http://tempuri.org/ISMURentItService/UploadBookResponse")]
        int UploadBook(string title, string author, string description, string genre, double price, System.IO.MemoryStream image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/UpdateBook", ReplyAction="http://tempuri.org/ISMURentItService/UpdateBookResponse")]
        RentIt.Team01Rentit.Book UpdateBook(int bookId, string title, string author, string description, string genre, System.Nullable<double> price, System.IO.MemoryStream image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/UploadAudio", ReplyAction="http://tempuri.org/ISMURentItService/UploadAudioResponse")]
        void UploadAudio(int bookId, System.IO.MemoryStream mp3, string narrator);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/UploadPdf", ReplyAction="http://tempuri.org/ISMURentItService/UploadPdfResponse")]
        void UploadPdf(int bookId, System.IO.MemoryStream pdf);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/DownloadImage", ReplyAction="http://tempuri.org/ISMURentItService/DownloadImageResponse")]
        System.IO.MemoryStream DownloadImage(int bookId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetActiveUserRentals", ReplyAction="http://tempuri.org/ISMURentItService/GetActiveUserRentalsResponse")]
        RentIt.Team01Rentit.Rental[] GetActiveUserRentals(int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISMURentItService/GetAllUserRentals", ReplyAction="http://tempuri.org/ISMURentItService/GetAllUserRentalsResponse")]
        RentIt.Team01Rentit.Rental[] GetAllUserRentals(int userId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISMURentItServiceChannel : RentIt.Team01Rentit.ISMURentItService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SMURentItServiceClient : System.ServiceModel.ClientBase<RentIt.Team01Rentit.ISMURentItService>, RentIt.Team01Rentit.ISMURentItService {
        
        public SMURentItServiceClient() {
        }
        
        public SMURentItServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SMURentItServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMURentItServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SMURentItServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int SignUp(string email, string name, string password, bool isAdmin) {
            return base.Channel.SignUp(email, name, password, isAdmin);
        }
        
        public int LogIn(string email, string password) {
            return base.Channel.LogIn(email, password);
        }
        
        public RentIt.Team01Rentit.User GetUserInfo(int userId) {
            return base.Channel.GetUserInfo(userId);
        }
        
        public RentIt.Team01Rentit.User UpdateUserInfo(int userId, string email, string username, string password, System.Nullable<bool> isAdmin) {
            return base.Channel.UpdateUserInfo(userId, email, username, password, isAdmin);
        }
        
        public void DeleteAccount(int userId) {
            base.Channel.DeleteAccount(userId);
        }
        
        public RentIt.Team01Rentit.Book[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public RentIt.Team01Rentit.Book[] GetPopularBooks() {
            return base.Channel.GetPopularBooks();
        }
        
        public RentIt.Team01Rentit.Book[] GetNewBooks() {
            return base.Channel.GetNewBooks();
        }
        
        public RentIt.Team01Rentit.Book[] SearchBooks(string searchString) {
            return base.Channel.SearchBooks(searchString);
        }
        
        public RentIt.Team01Rentit.Book[] GetBooksByGenre(string genre) {
            return base.Channel.GetBooksByGenre(genre);
        }
        
        public RentIt.Team01Rentit.Book GetBookInfo(int bookId) {
            return base.Channel.GetBookInfo(bookId);
        }
        
        public int HasRental(int userId, int bookId) {
            return base.Channel.HasRental(userId, bookId);
        }
        
        public RentIt.Team01Rentit.Rental[] GetRental(int userId, int bookId) {
            return base.Channel.GetRental(userId, bookId);
        }
        
        public int RentBook(int userId, int bookId, int mediaType) {
            return base.Channel.RentBook(userId, bookId, mediaType);
        }
        
        public System.IO.MemoryStream DownloadPdf(int bookId) {
            return base.Channel.DownloadPdf(bookId);
        }
        
        public System.IO.MemoryStream DownloadAudio(int bookId) {
            return base.Channel.DownloadAudio(bookId);
        }
        
        public void DeleteBook(int bookId) {
            base.Channel.DeleteBook(bookId);
        }
        
        public int UploadBook(string title, string author, string description, string genre, double price, System.IO.MemoryStream image) {
            return base.Channel.UploadBook(title, author, description, genre, price, image);
        }
        
        public RentIt.Team01Rentit.Book UpdateBook(int bookId, string title, string author, string description, string genre, System.Nullable<double> price, System.IO.MemoryStream image) {
            return base.Channel.UpdateBook(bookId, title, author, description, genre, price, image);
        }
        
        public void UploadAudio(int bookId, System.IO.MemoryStream mp3, string narrator) {
            base.Channel.UploadAudio(bookId, mp3, narrator);
        }
        
        public void UploadPdf(int bookId, System.IO.MemoryStream pdf) {
            base.Channel.UploadPdf(bookId, pdf);
        }
        
        public System.IO.MemoryStream DownloadImage(int bookId) {
            return base.Channel.DownloadImage(bookId);
        }
        
        public RentIt.Team01Rentit.Rental[] GetActiveUserRentals(int userId) {
            return base.Channel.GetActiveUserRentals(userId);
        }
        
        public RentIt.Team01Rentit.Rental[] GetAllUserRentals(int userId) {
            return base.Channel.GetAllUserRentals(userId);
        }
    }
}
