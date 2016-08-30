using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTJ.Base.DataLayer
{
    public abstract class Base<I, T, D,R1,R2,R3,R4,R5,R6,R7,R8>
    {
        protected D ctx = default(D);
        protected DateTime timeView = DateTime.Now;
        protected List<T> lstResults = default(List<T>);
        protected T result = default(T);
        protected Base.MessageChannel.MessageChannel msgChannel = null;

        protected virtual void initiate() { throw new NotImplementedException(); }

        protected virtual List<T> getAll()
        {
            try
            {
                return all();
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual List<T> all()
        {
            throw new NotImplementedException();
        }

        protected virtual T getById(I id)
        {
            try
            {
                 return byId(id);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return default(T);
            }
        }

        protected virtual T byId(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy1(object value)
        {
            try
            {
                setMessageChannel();
                return by1(value);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual List<T> by1(object value)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy2(object value)
        {
            try
            {
                return by2(value);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual List<T> by2(object value)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy3(object value)
        {
            try
            {
                return by3(value);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual List<T> by3(object value)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy4(object value)
        {
            try
            {
                return by4(value);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual List<T> by4(object value)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> getBy5(object value)
        {
            try
            {
                return by5(value);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual List<T> by5(object value)
        {
            throw new NotImplementedException();
        }

        protected virtual bool exists(List<T> lstItems)
        {
            try
            {
                return existsItems(lstItems);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return false;
            }
        }

        protected virtual bool existsItems(List<T> lstItems)
        {
            throw new NotImplementedException();
        }

        protected virtual bool exists(List<I> lstIds)
        {
            try
            {
                return existsItems(lstIds);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return false;
            }
        }

        protected virtual bool existsItems(List<I> lstItems)
        {
            throw new NotImplementedException();
        }

        protected virtual object getByRelation(object relation, I id)
        {
            object lstResults = null;
            try
            {
                if (isRelation1(relation.ToString()))
                {
                    lstResults = getRelation1(id);
                }
                if (isRelation2(relation.ToString()))
                {
                    lstResults = getRelation2(id);
                }
                if (isRelation3(relation.ToString()))
                {
                    lstResults = getRelation3(id);
                }
                if (isRelation4(relation.ToString()))
                {
                    lstResults = getRelation4(id);
                }
                if (isRelation5(relation.ToString()))
                {
                    lstResults = getRelation5(id);
                }
                if (isRelation6(relation.ToString()))
                {
                    lstResults = getRelation6(id);
                }
                if (isRelation7(relation.ToString()))
                {
                    lstResults = getRelation7(id);
                }
                if (isRelation8(relation.ToString()))
                {
                    lstResults = getRelation8(id);
                }
                return lstResults;
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }
        
        protected virtual bool isRelation1(string relation)
        {
            return false;
        }

        protected virtual object getRelation1(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation2(string relation)
        {
            return false;
        }

        protected virtual object getRelation2(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation3(string relation)
        {
            return false;
        }

        protected virtual object getRelation3(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation4(string relation)
        {
            return false;
        }

        protected virtual object getRelation4(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation5(string relation)
        {
            return false;
        }

        protected virtual object getRelation5(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation6(string relation)
        {
            return false;
        }

        protected virtual object getRelation6(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation7(string relation)
        {
            return false;
        }

        protected virtual object getRelation7(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation8(string relation)
        {
            return false;
        }

        protected virtual object getRelation8(I id)
        {
            throw new NotImplementedException();
        }

        protected virtual object getByRelation(object relation, List<I> ids)
        {
            object lstResults = null;
            try
            {
                if (isRelation11(relation.ToString()))
                {
                    lstResults = getRelation11(ids);
                }
                if (isRelation12(relation.ToString()))
                {
                    lstResults = getRelation12(ids);
                }
                if (isRelation13(relation.ToString()))
                {
                    lstResults = getRelation13(ids);
                }
                if (isRelation14(relation.ToString()))
                {
                    lstResults = getRelation14(ids);
                }
                if (isRelation15(relation.ToString()))
                {
                    lstResults = getRelation15(ids);
                }
                if (isRelation16(relation.ToString()))
                {
                    lstResults = getRelation16(ids);
                }
                if (isRelation17(relation.ToString()))
                {
                    lstResults = getRelation17(ids);
                }
                if (isRelation18(relation.ToString()))
                {
                    lstResults = getRelation18(ids);
                }
                return lstResults;
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual bool isRelation11(string relation)
        {
            return false;
        }

        protected virtual object getRelation11(List<I> id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation12(string relation)
        {
            return false;
        }

        protected virtual object getRelation12(List<I> id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation13(string relation)
        {
            return false;
        }

        protected virtual object getRelation13(List<I> id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation14(string relation)
        {
            return false;
        }

        protected virtual object getRelation14(List<I> id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation15(string relation)
        {
            return false;
        }

        protected virtual object getRelation15(List<I> id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation16(string relation)
        {
            return false;
        }

        protected virtual object getRelation16(List<I> id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation17(string relation)
        {
            return false;
        }

        protected virtual object getRelation17(List<I> id)
        {
            throw new NotImplementedException();
        }

        protected virtual bool isRelation18(string relation)
        {
            return false;
        }

        protected virtual object getRelation18(List<I> id)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> add(List<T> lstItems)
        {
            try
            {
                return addItems(lstItems);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual List<T> addItems(List<T> lstItems)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> update(List<T> lstItems)
        {
            lstItems = updateItems(lstItems);
            return lstItems;
        }

        protected virtual List<T> updateItems(List<T> lstItems)
        {
            throw new NotImplementedException();
        }

        protected virtual List<T> delete(List<T> lstItems)
        {
            try
            {
                return deleteItems(lstItems);
            }
            catch (Exception ex)
            {
                msgChannel.AddMessage(MessageChannel.Message.MessageType.Abbend, ex.Message);
                return null;
            }
        }

        protected virtual List<T> deleteItems(List<T> lstItems)
        {
            throw new NotImplementedException();
        }

        public virtual DateTime TimeView
        {
            get { return this.timeView; }
            set { this.timeView = value; }
        }

        public virtual bool isTimeViewSet()
        {
            return this.timeView != DateTime.Now;
        }

        protected virtual void setMessageChannel()
        {
            
        }

        public virtual MessageChannel.MessageChannel MsgChannel
        {
            get { return this.msgChannel; }
            set { this.msgChannel = value; }
        }
    }

    public class Nothing { }
}
