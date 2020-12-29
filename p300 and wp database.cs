using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Migrations
    public class Migrations
    {
        #region Member Variables
        protected int _id;
        protected string _migration;
        protected int _batch;
        #endregion
        #region Constructors
        public Migrations() { }
        public Migrations(string migration, int batch)
        {
            this._migration=migration;
            this._batch=batch;
        }
        #endregion
        #region Public Properties
        public virtual int Id
        {
            get {return _id;}
            set {_id=value;}
        }
        public virtual string Migration
        {
            get {return _migration;}
            set {_migration=value;}
        }
        public virtual int Batch
        {
            get {return _batch;}
            set {_batch=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_admin
    public class Tbl_admin
    {
        #region Member Variables
        protected int _admin_id;
        protected string _admin_email;
        protected string _admin_password;
        protected string _admin_name;
        protected string _admin_phone;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_admin() { }
        public Tbl_admin(string admin_email, string admin_password, string admin_name, string admin_phone, unknown created_at, unknown updated_at)
        {
            this._admin_email=admin_email;
            this._admin_password=admin_password;
            this._admin_name=admin_name;
            this._admin_phone=admin_phone;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Admin_id
        {
            get {return _admin_id;}
            set {_admin_id=value;}
        }
        public virtual string Admin_email
        {
            get {return _admin_email;}
            set {_admin_email=value;}
        }
        public virtual string Admin_password
        {
            get {return _admin_password;}
            set {_admin_password=value;}
        }
        public virtual string Admin_name
        {
            get {return _admin_name;}
            set {_admin_name=value;}
        }
        public virtual string Admin_phone
        {
            get {return _admin_phone;}
            set {_admin_phone=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_category
    public class Tbl_category
    {
        #region Member Variables
        protected int _category_id;
        protected string _category_name;
        protected string _category_description;
        protected int _publication_status;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_category() { }
        public Tbl_category(string category_name, string category_description, int publication_status, unknown created_at, unknown updated_at)
        {
            this._category_name=category_name;
            this._category_description=category_description;
            this._publication_status=publication_status;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Category_id
        {
            get {return _category_id;}
            set {_category_id=value;}
        }
        public virtual string Category_name
        {
            get {return _category_name;}
            set {_category_name=value;}
        }
        public virtual string Category_description
        {
            get {return _category_description;}
            set {_category_description=value;}
        }
        public virtual int Publication_status
        {
            get {return _publication_status;}
            set {_publication_status=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_customer
    public class Tbl_customer
    {
        #region Member Variables
        protected int _customer_id;
        protected string _customer_name;
        protected string _customer_email;
        protected string _customer_password;
        protected string _mobile_number;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_customer() { }
        public Tbl_customer(string customer_name, string customer_email, string customer_password, string mobile_number, unknown created_at, unknown updated_at)
        {
            this._customer_name=customer_name;
            this._customer_email=customer_email;
            this._customer_password=customer_password;
            this._mobile_number=mobile_number;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Customer_id
        {
            get {return _customer_id;}
            set {_customer_id=value;}
        }
        public virtual string Customer_name
        {
            get {return _customer_name;}
            set {_customer_name=value;}
        }
        public virtual string Customer_email
        {
            get {return _customer_email;}
            set {_customer_email=value;}
        }
        public virtual string Customer_password
        {
            get {return _customer_password;}
            set {_customer_password=value;}
        }
        public virtual string Mobile_number
        {
            get {return _mobile_number;}
            set {_mobile_number=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_manufacture
    public class Tbl_manufacture
    {
        #region Member Variables
        protected int _manufacture_id;
        protected string _manufacture_name;
        protected string _manufacture_description;
        protected int _publication_status;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_manufacture() { }
        public Tbl_manufacture(string manufacture_name, string manufacture_description, int publication_status, unknown created_at, unknown updated_at)
        {
            this._manufacture_name=manufacture_name;
            this._manufacture_description=manufacture_description;
            this._publication_status=publication_status;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Manufacture_id
        {
            get {return _manufacture_id;}
            set {_manufacture_id=value;}
        }
        public virtual string Manufacture_name
        {
            get {return _manufacture_name;}
            set {_manufacture_name=value;}
        }
        public virtual string Manufacture_description
        {
            get {return _manufacture_description;}
            set {_manufacture_description=value;}
        }
        public virtual int Publication_status
        {
            get {return _publication_status;}
            set {_publication_status=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_order
    public class Tbl_order
    {
        #region Member Variables
        protected int _order_id;
        protected int _customer_id;
        protected int _payment_id;
        protected int _ordert_total;
        protected string _order_status;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_order() { }
        public Tbl_order(int customer_id, int payment_id, int ordert_total, string order_status, unknown created_at, unknown updated_at)
        {
            this._customer_id=customer_id;
            this._payment_id=payment_id;
            this._ordert_total=ordert_total;
            this._order_status=order_status;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Order_id
        {
            get {return _order_id;}
            set {_order_id=value;}
        }
        public virtual int Customer_id
        {
            get {return _customer_id;}
            set {_customer_id=value;}
        }
        public virtual int Payment_id
        {
            get {return _payment_id;}
            set {_payment_id=value;}
        }
        public virtual int Ordert_total
        {
            get {return _ordert_total;}
            set {_ordert_total=value;}
        }
        public virtual string Order_status
        {
            get {return _order_status;}
            set {_order_status=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_order_details
    public class Tbl_order_details
    {
        #region Member Variables
        protected int _order_details_id;
        protected int _order_id;
        protected int _product_id;
        protected int _product_name;
        protected int _product_price;
        protected int _product_sales_quantity;
        protected string _order_status;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_order_details() { }
        public Tbl_order_details(int order_id, int product_id, int product_name, int product_price, int product_sales_quantity, string order_status, unknown created_at, unknown updated_at)
        {
            this._order_id=order_id;
            this._product_id=product_id;
            this._product_name=product_name;
            this._product_price=product_price;
            this._product_sales_quantity=product_sales_quantity;
            this._order_status=order_status;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Order_details_id
        {
            get {return _order_details_id;}
            set {_order_details_id=value;}
        }
        public virtual int Order_id
        {
            get {return _order_id;}
            set {_order_id=value;}
        }
        public virtual int Product_id
        {
            get {return _product_id;}
            set {_product_id=value;}
        }
        public virtual int Product_name
        {
            get {return _product_name;}
            set {_product_name=value;}
        }
        public virtual int Product_price
        {
            get {return _product_price;}
            set {_product_price=value;}
        }
        public virtual int Product_sales_quantity
        {
            get {return _product_sales_quantity;}
            set {_product_sales_quantity=value;}
        }
        public virtual string Order_status
        {
            get {return _order_status;}
            set {_order_status=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_payment
    public class Tbl_payment
    {
        #region Member Variables
        protected int _payment_id;
        protected string _payment_method;
        protected string _payment_status;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_payment() { }
        public Tbl_payment(string payment_method, string payment_status, unknown created_at, unknown updated_at)
        {
            this._payment_method=payment_method;
            this._payment_status=payment_status;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Payment_id
        {
            get {return _payment_id;}
            set {_payment_id=value;}
        }
        public virtual string Payment_method
        {
            get {return _payment_method;}
            set {_payment_method=value;}
        }
        public virtual string Payment_status
        {
            get {return _payment_status;}
            set {_payment_status=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_products
    public class Tbl_products
    {
        #region Member Variables
        protected int _product_id;
        protected string _product_name;
        protected int _category_id;
        protected int _manufacture_id;
        protected string _product_short_description;
        protected string _product_long_description;
        protected unknown _product_price;
        protected string _product_image;
        protected string _product_size;
        protected string _product_color;
        protected int _publication_status;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_products() { }
        public Tbl_products(string product_name, int category_id, int manufacture_id, string product_short_description, string product_long_description, unknown product_price, string product_image, string product_size, string product_color, int publication_status, unknown created_at, unknown updated_at)
        {
            this._product_name=product_name;
            this._category_id=category_id;
            this._manufacture_id=manufacture_id;
            this._product_short_description=product_short_description;
            this._product_long_description=product_long_description;
            this._product_price=product_price;
            this._product_image=product_image;
            this._product_size=product_size;
            this._product_color=product_color;
            this._publication_status=publication_status;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Product_id
        {
            get {return _product_id;}
            set {_product_id=value;}
        }
        public virtual string Product_name
        {
            get {return _product_name;}
            set {_product_name=value;}
        }
        public virtual int Category_id
        {
            get {return _category_id;}
            set {_category_id=value;}
        }
        public virtual int Manufacture_id
        {
            get {return _manufacture_id;}
            set {_manufacture_id=value;}
        }
        public virtual string Product_short_description
        {
            get {return _product_short_description;}
            set {_product_short_description=value;}
        }
        public virtual string Product_long_description
        {
            get {return _product_long_description;}
            set {_product_long_description=value;}
        }
        public virtual unknown Product_price
        {
            get {return _product_price;}
            set {_product_price=value;}
        }
        public virtual string Product_image
        {
            get {return _product_image;}
            set {_product_image=value;}
        }
        public virtual string Product_size
        {
            get {return _product_size;}
            set {_product_size=value;}
        }
        public virtual string Product_color
        {
            get {return _product_color;}
            set {_product_color=value;}
        }
        public virtual int Publication_status
        {
            get {return _publication_status;}
            set {_publication_status=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_shipping
    public class Tbl_shipping
    {
        #region Member Variables
        protected int _shipping_id;
        protected string _shipping_email;
        protected string _shipping_first_name;
        protected string _shipping_last_name;
        protected string _shipping_address;
        protected string _shipping_mobile_number;
        protected string _shipping_city;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_shipping() { }
        public Tbl_shipping(string shipping_email, string shipping_first_name, string shipping_last_name, string shipping_address, string shipping_mobile_number, string shipping_city, unknown created_at, unknown updated_at)
        {
            this._shipping_email=shipping_email;
            this._shipping_first_name=shipping_first_name;
            this._shipping_last_name=shipping_last_name;
            this._shipping_address=shipping_address;
            this._shipping_mobile_number=shipping_mobile_number;
            this._shipping_city=shipping_city;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Shipping_id
        {
            get {return _shipping_id;}
            set {_shipping_id=value;}
        }
        public virtual string Shipping_email
        {
            get {return _shipping_email;}
            set {_shipping_email=value;}
        }
        public virtual string Shipping_first_name
        {
            get {return _shipping_first_name;}
            set {_shipping_first_name=value;}
        }
        public virtual string Shipping_last_name
        {
            get {return _shipping_last_name;}
            set {_shipping_last_name=value;}
        }
        public virtual string Shipping_address
        {
            get {return _shipping_address;}
            set {_shipping_address=value;}
        }
        public virtual string Shipping_mobile_number
        {
            get {return _shipping_mobile_number;}
            set {_shipping_mobile_number=value;}
        }
        public virtual string Shipping_city
        {
            get {return _shipping_city;}
            set {_shipping_city=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Eshop
{
    #region Tbl_slider
    public class Tbl_slider
    {
        #region Member Variables
        protected int _slider_id;
        protected string _slider_image;
        protected int _publication_status;
        protected unknown _created_at;
        protected unknown _updated_at;
        #endregion
        #region Constructors
        public Tbl_slider() { }
        public Tbl_slider(string slider_image, int publication_status, unknown created_at, unknown updated_at)
        {
            this._slider_image=slider_image;
            this._publication_status=publication_status;
            this._created_at=created_at;
            this._updated_at=updated_at;
        }
        #endregion
        #region Public Properties
        public virtual int Slider_id
        {
            get {return _slider_id;}
            set {_slider_id=value;}
        }
        public virtual string Slider_image
        {
            get {return _slider_image;}
            set {_slider_image=value;}
        }
        public virtual int Publication_status
        {
            get {return _publication_status;}
            set {_publication_status=value;}
        }
        public virtual unknown Created_at
        {
            get {return _created_at;}
            set {_created_at=value;}
        }
        public virtual unknown Updated_at
        {
            get {return _updated_at;}
            set {_updated_at=value;}
        }
        #endregion
    }
    #endregion
}