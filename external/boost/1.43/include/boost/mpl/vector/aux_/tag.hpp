
#include <boost/mpl/aux_/config/typeof.hpp>
#include <boost/mpl/aux_/nttp_decl.hpp>

namespace boost { namespace mpl { namespace aux {

struct v_iter_tag;

#if defined(BOOST_MPL_CFG_TYPEOF_BASED_SEQUENCES)
struct vector_tag;
#else
template< BOOST_MPL_AUX_NTTP_DECL(long, N) > struct vector_tag;
#endif

}}}

#endif // BOOST_MPL_VECTOR_AUX_TAG_HPP_INCLUDED
