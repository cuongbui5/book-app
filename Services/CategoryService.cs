using Book_App.Repository;
using System;
using System.Collections.Generic;
using Book_App.Models;
using System.Data;

namespace Book_App.Services
{
    class CategoryService
    {
        private static CategoryService instance;

        public static CategoryService Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CategoryService();
                }
                return instance;
            }
        }

        public List<Category> getListCategory()
        {
            return CategoryRepository.Instance.GetListCategories();
        }
        public DataSet GetAllCategories()
        {
            DataSet data = CategoryRepository.Instance.GetAllCategories();
            return data;
        }

        public bool CreateCategory(String name) {        
            Category category = new Category()
            {
                Name = name
            };
            return CategoryRepository.Instance.CreateCategory(category);
        }

        public bool updateCategoryById(String name,string id)
        {

            return CategoryRepository.Instance.UpdateCategoryById(name,id);


        }

        public bool deleteCategoryById(string id)
        {

            return CategoryRepository.Instance.DeleteCategoryById(id);

        }
    }
}
