using AutoMapper;
using RV.Models;
using RV.Repository;
using RV.Views.DTO;

namespace RV.Services.DataProviderServices.SQL
{
    public class SQLNoteDataProvider : INoteDataProvider
    {
        private INoteRepository _repository;
        private IMapper _mapper;

        public SQLNoteDataProvider(INoteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public NoteDTO CreateNote(NoteAddDTO item)
        {
            Note n = _mapper.Map<Note>(item);
            var res = _repository.CreateNote(n);
            return _mapper.Map<NoteDTO>(res);
        }

        public int DeleteNote(int id)
        {
            int res = _repository.DeleteNote(id);
            return res;
        }

        public NoteDTO GetNote(int id)
        {
            return _mapper.Map<NoteDTO>(_repository.GetNote(id));
        }

        public List<NoteDTO> GetNotes()
        {
            List<NoteDTO> res = [];
            foreach (Note n in _repository.GetNotes())
            {
                res.Add(_mapper.Map<NoteDTO>(n));
            }
            return res;
        }

        public NoteDTO UpdateNote(NoteUpdateDTO item)
        {
            var n = _mapper.Map<Note>(item);
            var res = _repository.UpdateNote(n);
            return _mapper.Map<NoteDTO>(res);
        }
    }
}
