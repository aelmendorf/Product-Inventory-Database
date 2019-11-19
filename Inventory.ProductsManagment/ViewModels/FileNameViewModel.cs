﻿namespace Inventory.ProductsManagment.ViewModels {
    public class FileNameViewModel {
        public FileNameViewModel() {
            this.FileName = "";
            this.Description = "";
        }

        public FileNameViewModel(string currentFile) {
            if (string.IsNullOrEmpty(currentFile)) {
                this.FileName = currentFile;
            } else {
                this.FileName = "";
            }

            this.Description = "";
        }

        public virtual string FileName { get; set; }
        public virtual string Description { get; set; }
    }
}